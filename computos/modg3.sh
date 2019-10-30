 clear
 gpasswd -a $usernamechecked $nombregchecked >/dev/null
 echo "EL MIEMBRO SE HA AÑADIDO AL GRUPO SATISFACTORIAMENTE"
 logger -p local4.info "Un miembro se ha anadido a: $nombregchecked"
 read aux
	sh modg.sh
