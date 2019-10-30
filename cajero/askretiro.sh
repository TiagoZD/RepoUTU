clear
echo "Ingrese el monto que desee retirar"
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
				abc=$(echo select id_cuenta from tarjeta where numt = $nrot | dbaccess databank > file2)
				idret=$(head -5 file2 | tail -1)
				sql=$(echo update cuenta set saldo = saldo - $monto where id_cuenta = $idret | dbaccess databank)
				clear
				echo "El retiro ha sido realizado con exito"
				logger -p local5.info "Se ha realizado un retiro en la cuenta"
				read var
				sh cajero.sh

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

