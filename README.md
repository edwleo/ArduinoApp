# Código en C para Arduino

```
long valorPot = 0;
int valorEntrada = 0;
int estadoLed = 0;

void setup() {
  // put your setup code here, to run once:
  pinMode(2, OUTPUT);
  Serial.begin(9600);
}

void loop() {
  valorPot = analogRead(A0);
  Serial.println(valorPot);

  valorEntrada = Serial.parseInt();

  if (Serial.available()){
    if (valorEntrada == 1){
      estadoLed = 1;
    }else{
      estadoLed = 0;
    }
  }
  digitalWrite(2, estadoLed);

  delay(500);
}
```
