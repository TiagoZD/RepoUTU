echo "Ingrese el nuevo nombre"
read newname
	namecheck=$(grep -w $newname /etc/group | cut -d ":" -f1)
	if [ "$newname" = "$namecheck" ]
		then
			clear 
			echo "EL GRUPO YA EXISTE"
			read aux
			sh modg.sh
		else
                        groupmod -n $newname $nombregchecked
                        clear
                      	echo "EL GRUPO SE HA RENOMBRADO A: $newname"
			logger -p local4.info "Se modifico el nombre del grupo: $namecheck"
                        read aux
                        sh modg.sh
        fi

