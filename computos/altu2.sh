echo "SE ENCUENTRA AQUI"
pwd
echo "Ingrese la direccion del directorio para el usuario"   	
	read diru
	clear
	dircheck=$(grep -w $diru /etc/passwd | cut -d ":" -f6)
	if [ "$diru" = "$dircheck" ]
		then 
			echo "LA RUTA DEL DIRECTORIO INGRESADO YA EXISTE"
			read aux
			sh altu.sh
		else  
			echo "Ingrese la contraseña para el usuario"
                        read passu
                        clear
                        useradd -md $diru $nombusr
                        usermod -p $passu $nombusr
			echo "EL USUARIO HA SIDO CREADO SATISFATORIAMENTE"
			logger -p local4.info "El usuario $nombreusr se ha creado"
			read aux
			sh abm.sh
	fi
			

