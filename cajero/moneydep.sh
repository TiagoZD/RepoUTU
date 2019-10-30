clear
echo "Ingrese el monto a depositar"
read monto

if [ "$monto" -ge 1 ]
	then
		clear
		echo "Ingrese la cuenta de destino"
		read sentid
		
		sql=$(echo select id_cuenta from cuenta where id_cuenta = $sentid | dbaccess databank > consulta)
                sentidck=$(head -5 consulta | tail -1)
	
		if [ "$sentid" -eq "$sentidck" ]
			
			then
				clear
				sql=$(echo update cuenta set saldo = saldo + $monto where id_cuenta = $sentid | dbaccess databank)
				clear
 				echo "El deposito se ha realizado con exito"
               			logger -p local5.info "Se ha depositado un monto en la cuenta $sentid"
				read var
				sh cajero.sh
			else
				clear
				echo "La cuenta ingresada no existe"
				read var
				sh cajero.sh

		fi
	else	
		clear
		echo "MONTO INVALIDO"
		read var
fi

   
