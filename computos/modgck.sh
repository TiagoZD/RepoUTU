clear
     echo "Ingrese el nombre del grupo"
     read nombreg
     groupck=$(grep -w $nombreg /etc/group | cut -d ":" -f1)
     

	if [ "$nombreg" = "$groupck" ]
     		then	 
			 clear
			 nombregchecked=$nombreg
    		 	 export nombregchecked=$nombregchecked
			 sh modg.sh	
		
		else	
			clear
			echo "EL GRUPO NO EXISTE"
			read aux
			sh abm.sh
	fi

		

