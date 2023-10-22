String inputString = ""; // a string to  hold incomming data
bool stringComplete = false ;

void setup() 
{
  Serial.begin(9600);
  pinMode(2, OUTPUT);
  digitalWrite(2, LOW);
}

void loop() 
{
   if (stringComplete)
   {
     inputString.trim();
     Serial.println(inputString);

     if (inputString.equals("$On"))
     {
       digitalWrite(2, HIGH);
     }
     else if (inputString.equals("$Off"))
     {
       digitalWrite(2, LOW);
     } 

     inputString = "";
     stringComplete = false;
   }
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

