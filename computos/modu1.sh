echo "Ingrese el grupo al que quiera asignar el usuario"
                                                read nombreg
                                                gcheck=$(grep -w $nombreg /etc/group | cut -d ":" -f1)

                                                if [ "$nombre" = "$gcheck"]
                                                        then
                                                                clear
                                                                useradd -a -G $nombreg $uname
                                                                echo "EL USUARIO SE HA ASIGNADO AL GRUPO SATISFACTORIAMENTE"
								logger -p local4.info "Se ha anadido el usuaro $uname a al grupo $nombreg"
                                                                read aux
                                                                sh modu.sh
                                                        else
                                                                clear
                                                                echo "EL GRUPO NO EXISTE"
                                                                read aux
                                                                sh modu.sh
                                                fi

