
total=0
monto=float(input("Monto de la venta: $"))
while monto!=0:
    if monto<0:
        print("Monto no válido.")
    else:
        total=total+monto
    monto=float(input("Monto de una venta: $"))
if total>1000:
    total=total * 10 / 100
print("Monto total a pagar: $", total)        

