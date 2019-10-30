clear
echo "Ingrese la nueva contraseña"
                                                read newpass
                                                groupmod -p $newpass $nombregchecked
                                                clear
                                                echo "SE HA CAMBIADO LA CONTRASEÑA SATISFACTORIAMENTE"
                                                logger -p local4.info "Se ha cambiado la contraseña de $nombregchecked"
						read aux
                                                sh modg.sh
                                                

