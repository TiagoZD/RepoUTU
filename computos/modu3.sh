echo "Ingrese la contraseña para el usuario"
                                                read passumod
						clear
                                                usermod -p $passumod $unameall
                                                echo "LA CONTRASEÑA SE HA CAMBIADO SATISFACTORIA"
						logger -p local4.info "Se cambio la contrasena de $unameall" 
                                                read aux
						clear

