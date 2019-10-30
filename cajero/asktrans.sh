clear
echo "Ingrese el monto que desee transferir"
read monto
if [ "$monto" -ge 1 ]
        then
                sql=$(echo select saldo from tarjeta, cuenta where tarjeta.id_cuenta = cuenta.id_cuenta AND numt = $nrot | dbaccess databank > file)
                var2=$(head -5 file | tail -1 | cut -d "." -f1)
                a=${var2//$}
                saldoA=$(echo $a)

                if [ "$monto" -le "$saldoA" ]

                        then
				
                                clear
				echo "Inserte la ID de la cuenta destino"
				read destid
				sql=$(echo select id_cuenta from cuenta where id_cuenta = $destid | dbaccess databank > trans)
		                transidck=$(head -5 trans | tail -1)
			
				if [ "$destid" -eq "$transidck" ]
			
					then
						abc=$(echo select id_cuenta from tarjeta where numt = $nrot | dbaccess databank > file2)
                        		        myacc=$(head -5 file2 | tail -1)
						moneyout=$(echo update cuenta set saldo = saldo - $monto where id_cuenta = $myacc | dbaccess databank)
                                		moneyin=$(echo update cuenta set saldo = saldo + $monto where id_cuenta = $destid | dbaccess databank)
                                		
                                		echo "La transferencia se ha sido realizado con exito"
						logger -p local5.info "Se ha transferido un monto a la cuenta $destid"
                                		read var
                                		sh cajero.sh
					else
						clear
						echo "La ID ingresada no existe"
						read var
						sh cajero.sh
				fi

                       	 else
                                clear
                                echo "Saldo insuficiente"
                                read var
                                sh cajero.sh

                fi
        else
                clear
                echo "MONTO INVALIDO"
                read var
                sh cajero.sh
fi

