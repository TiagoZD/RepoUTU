clear
echo "Ingrese el nombre del usuario"
	read nombreu
	clear
	ucheck=$(grep -w $nombreu /etc/shadow | cut -d ":" -f1)
	if [ "$nombreu" = "$ucheck" ]

		then 
			 echo "EL USUARIO YA EXISTE"
			 read aux
			 sh abm.sh
		else
	         	 nombusr=$nombreu
       	 	         export nombusr=$nombusr
			 sh altu2.sh

	fi

