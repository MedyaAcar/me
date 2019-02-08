#include <NewPing.h>
#include <Servo.h>
Servo motor; 

#define TRIGGER_PIN  11 
#define ECHO_PIN     12  
#define MAX_DISTANCE 200
NewPing sonar(TRIGGER_PIN, ECHO_PIN, MAX_DISTANCE);


void setup() { 
motor.attach(3);
Serial.begin(115200);


  }

void loop() { 
  int enkucuk=200;
  int a;
  
for(int m =0; m<180; m+=3)
{
motor.write(m); 
delay(100);
if(sonar.ping_cm()<enkucuk && sonar.ping_cm()!=0)
{
  enkucuk=sonar.ping_cm();
  a=m;
  
  }

                     
  Serial.print("Ping: ");
  Serial.print(sonar.ping_cm());
  Serial.println("cm");
}
motor.write(a);
delay(2000); 
}
