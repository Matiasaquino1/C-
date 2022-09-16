from calendar import c
import random 

for i in range(4):
  jugador1_hero = random.randint(1, 6)
  print("en el dado salio: ", jugador1_hero)    
  
  if jugador1_hero == 1:       
      print ("un punto")
  elif jugador1_hero == 2:
      print ("ningun punto")
  elif jugador1_hero == 4:
    print ("ningun punto")
  elif jugador1_hero == 6:
    print ("ningun punto")
  elif jugador1_hero == 3:
    print ("dos puntos")
  elif jugador1_hero == 5:
    print ("cuatro puntos")
  else:
    print ("salieron todos pares")

  def suma(jugador1_hero):
    suma1 = (jugador1_hero+jugador1_hero+jugador1_hero)
    print("el resultado es: ", suma1)
  