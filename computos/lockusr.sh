clear
	echo "Ingrese el usuario que quiera bloquear"
	read locku
		
	lockuck=$(grep -w $locku /etc/shadow | cut -d ":" -f1)
	
	if [ "$locku" = "$lockuck" ]
		then
			clear
			usermod -L $locku >/dev/null
			echo "EL USUARIO HA SIDO BLOQUEADO SATISFACTORIAMENTE"
			logger -p local4.info "El usuario $locku ha sido bloqueado"
			read aux
			sh usercontrol.sh
		else
			clear
			echo "EL USUARIO NO EXISTE"
			read aux
			sh usercontrol.sh
	fi
