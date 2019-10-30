clear
						echo "Ingrese al miembro que quiera unir al grupo"
                                                read username

                                                unameck=$(grep -w $username /etc/shadow | cut -d ":" -f1)

                                                if [ "$username" = "$unameck" ]
                                                        then
                                                                clear
                                                                usernamechecked=$username
                                                                export usernamechecked=$usernamechecked
                                                                sh modg3.sh
                                                        else
								clear
                                                                echo "EL USUARIO NO EXISTE"
                                                                read aux
                                                                sh modg.sh
                                                fi


