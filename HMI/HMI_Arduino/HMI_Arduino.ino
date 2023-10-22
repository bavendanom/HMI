String inputString = ""; // a string to  hold incomming data
bool stringComplete = false ;

void setup() 
{
  Serial.begin(9600);
  pinMode(LED_BUILTIN, OUTPUT);
  digitalWrite(LED_BUILTIN, LOW);
}

void loop() 
{
   if (stringComplete)
   {
     inputString.trim();
     Serial.println(inputString);

     if (inputString.equals("$On"))
     {
       digitalWrite(LED_BUILTIN, HIGH);
     }
     else if (inputString.equals("$Off"))
     {
       digitalWrite(LED_BUILTIN, LOW);
     } 

     inputString = "";
     stringComplete = false;
   }
}

void serialEvent ()
{
  while (Serial.available())
  {
    char inChar = (char)Serial.read();
    if (inChar == '\n')
    {
      stringComplete = true;
    }
    else 
    {
      inputString += inChar;
    }
  }
}
