clear
                                                echo "Ingrese al miembro que quiera eliminar del grupo"
                                                read delusername
						delunameck=$(groups $delusername | cut -d ":" -f2)
						comparevar=" $delusername $nombregchecked"
                                                if [ "$delunameck" = "$comparevar" ]
                                                       
							 then
                                                                clear
                                                                delusernamechecked=$delusername
                                                                export delusernamechecked=$delusernamechecked
                                                                sh modg4.sh
                                                        else
				                                clear
                                                                echo "EL USUARIO NO SE ENCUENTRA EN EL GRUPO"
                                                                read aux
                                                                sh modg.sh
                                                fi


