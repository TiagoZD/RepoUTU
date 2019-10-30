echo "Ingrese el nuevo nombre para el usuario"
                                                read nuname
                                                nucheck=$(grep -w $nuname /etc/shadow | cut -d ":" -f1)
                                                if [ "$nuname" = "$nucheck" ]
                                                        then
                                                                clear
                                                                echo "EL NOMBRE DE USUARIO YA ESTA EN USO"
                                                                read aux
                                                                sh modu.sh
                                                        else
                                                                clear
                                                                usermod -l $nuname $namechecked 2>/dev/null
                                                                echo "EL USUARIO SE HA RENOMBRADO A: $nuname"
								logger -p local4.info "Se ha renombrado el usuario $nuname"
								read aux

                                                                sh modu.sh
                                                fi

