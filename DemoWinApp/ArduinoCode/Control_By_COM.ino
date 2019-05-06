// Demo điều khiển Arduino bằng USB trên PC
char val; //Code truyền vào để điều khiển

void setup() {
  pinMode(4, OUTPUT);
  pinMode(6, OUTPUT);
  Serial.begin(9600);
}

void loop() {
  
  while (Serial.available())
  {
    val = Serial.read();
    Serial.println(val);
    delay(100);
    if(val == '1')
    {
      digitalWrite(4, LOW);
    }
    else if(val == '2')
    {
      digitalWrite(4, HIGH);
    }
    else if(val == '3')
    {
      digitalWrite(6, LOW);
    }
    else if(val == '3')
    {
      digitalWrite(6, HIGH);
    }
  }
}
