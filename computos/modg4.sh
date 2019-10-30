clear
 gpasswd -d $delusernamechecked $nombregchecked >/dev/null
 echo "EL MIEMBRO SE HA ELIMINADO DEL GRUPO SATISFACTORIAMENTE"
 logger -p local4.info "Se ha eliminado un miembro de: $nombregchecked"
 read aux
        sh modg.sh
~                              
