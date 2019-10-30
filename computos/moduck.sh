clear 
	echo "Ingrese el nombre del usuario"
	read namemod
	nameck=$(grep -w $namemod /etc/shadow | cut -d ":" -f1)

		if [ "$namemod" = "$nameck" ]
			then
				clear
				namechecked=$namemod
				export namechecked=$namechecked
				sh modu.sh

			else
				clear
				echo "EL USUARIO NO EXISTE"
				read aux
				sh abm.sh
		fi	
