clear
      echo "Ingrese el nombre del usuario"
      read nombreu
	ucheck2=$(grep -w $nombreu /etc/shadow | cut -d ":" -f1)
        if [ "$nombreu" = "$ucheck2" ]

                then
			clear
                        userdel -r $nombreu 2>/dev/null
                        echo "EL USUARIO HA SIDO ELIMINADO SATISFACTORIAMENTE"
			logger -p local4.info "Se ha eliminado el usuario $nombreu"
                        read aux
                        sh abm.sh
		else
			clear
                        echo "EL USUARIO NO EXISTE"
                        read aux
                        sh abm.sh



        fi

