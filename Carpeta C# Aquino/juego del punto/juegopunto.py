import random

for i in range(1):
    a = random.randrange(1, 6)
    b = random.randrange(1, 6)
    c = random.randrange(1, 6)
    d = random.randrange(1, 6)
    
    print ("lanzar dados...")
    print ("el resultado es...")
    print ("", a)
    if a == 1:
        print ("un punto")
    elif a == 2:
        print ("ningun punto")
    elif a == 4:
        print ("ningun punto")
    elif a == 6:
        print ("ningun punto")
    elif a == 3:
        print ("dos puntos")
    elif a == 5:
        print ("cuatro puntos")
    print ("", b)
    if b == 1:
        print ("un punto")
    elif b == 2:
        print ("ningun punto")
    elif b == 4:
        print ("ningun punto")
    elif b == 6:
        print ("ningun punto")
    elif b == 3:
        print ("dos puntos")
    elif b == 5:
        print ("cuatro puntos")
    print ("", c)
    if c == 1:
        print ("un punto")
    elif c == 2:
        print ("ningun punto")
    elif c == 4:
        print ("ningun punto")
    elif c == 6:
        print ("ningun punto")
    elif c == 3:
        print ("dos puntos")
    elif c == 5:
        print ("cuatro puntos")
    print ("", d)
    if d == 1:
        print ("un punto")
    elif d == 2:
        print ("ningun punto")
    elif d == 4:
        print ("ningun punto")
    elif d == 6:
        print ("ningun punto")
    elif d == 3:
        print ("dos puntos")
    elif d == 5:
        print ("cuatro puntos")

    if a == b == c == d:
        print("Se le multiplicara al final")

    suma1 = (a+b+c+d)
    print("el resultado de la suma es: ", suma1)

