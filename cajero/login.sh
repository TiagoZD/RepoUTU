clear
echo "Ingrese su numero de tarjeta"
read nrot

nrotcheck=$(echo select numt from tarjeta where numt = $nrot | dbaccess databank | grep -w $nrot)>/dev/null

if [ "$nrot" -eq "$nrotcheck" ]
	then

		numt = $nrot
		export nrot = $nrot
		clear 
		echo “Ingrese su PIN”
		read pint
		pincheck=$(echo select pin from tarjeta where pin = $pint AND numt = $nrot | dbaccess databank | grep -w $pint)
		if [ "$pint" -eq "$pincheck" ] 
      
   		     	then
				logger -p local5.info "Se ha logeado $nrot"
               			sh cajero.sh
    
   			 else
             			 echo "PIN INCORRECTO"
      				 read var 
         			 exit
		fi  
 
	else
		clear
		echo "El numero ingresado no es correcto"
		read var
		exit
fi	
