from sympy import *
x00=Symbol('x00')
x01=Symbol('x01')
x02=Symbol('x02')
x03=Symbol('x03')
x04=Symbol('x04')
x05=Symbol('x05')
x06=Symbol('x06')
x07=Symbol('x07')
x08=Symbol('x08')
x09=Symbol('x09')
x10=Symbol('x10')
x11=Symbol('x11')
x12=Symbol('x12')
x13=Symbol('x13')
x14=Symbol('x14')
x15=Symbol('x15')
print(solve([

   x00+x01+x02+x03-10,
   x04+x05+x06+x07-10,
   x08+x09+x10+x11-10,
   x12+x13+x14+x15-10,


   x00*x01*x02*x03-24,
   x04*x05*x06*x07-24,
   x08*x09*x10*x11-24,
   x12*x13*x14*x15-24,


   x00+x04+x08+x12-10, 
   x01+x05+x09+x13-10,
   x02+x06+x10+x14-10,
   x03+x07+x11+x15-10,


   x00*x04*x08*x12-24,
   x01*x05*x09*x13-24,
   x02*x06*x10*x14-24,
   x03*x07*x11*x15-24,


   x00+x01+x04+x05-10,
   x02+x03+x06+x07-10,
   x08+x09+x12+x13-10,
   x10+x11+x14+x15-10,

   
   x00*x01*x04*x05-24,
   x02*x03*x06*x07-24,
   x08*x09*x12*x13-24,
   x10*x11*x14*x15-24,


   x00-1,
   x01-4,
   x14-1,
   x15-2
    ],[x00,x01,x02,x03,x04,x05,x06,x07,x08,x09,x10,x11,x12,x13,x14,x15]))