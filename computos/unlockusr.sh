clear
	echo "Ingrese el usuario que quiera desbloquear"
	read unlocku
	
	unlockuck=$(grep -w $unlocku /etc/shadow | cut -d ":" -f1)
	
	if [ "$unlocku" = "$unlockuck" ]
		then
			clear
			usermod -U $unlocku
			echo "EL USUARIO SE HA DESBLOQUEADO SATISFACTORIAMENTE"
			logger -p local4.info "El usuario $unlocku ha sido desbloqueado" 
			read aux
			sh usercontrol.sh
		else
			clear
			echo "EL USUARIO NO EXISTE"
			read aux
			sh usercontrol.sh
	fi

