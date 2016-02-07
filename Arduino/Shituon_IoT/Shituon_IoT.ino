#include "DHT.h"
#define DHTPIN 2
#define DHTTYPE DHT22

#define T_Calibration -8.2
#define H_Calibration 4.7

DHT dht(DHTPIN, DHTTYPE);

void setup() {
	Serial.begin(9600); 
	dht.begin();
}

void loop() {


	if (Serial.available() > 0){
		char Readtext = Serial.read();
		if(Readtext == 'd'){
			float Temperature = dht.readTemperature() + T_Calibration;
			float Humidity = dht.readHumidity() + H_Calibration;
			if (isnan(Humidity) || isnan(Temperature)) {
				Serial.println("Failed to read from sensor");
				return;
			}
			Serial.print(Temperature);
			Serial.print(","); 
			Serial.print(Humidity);
			Serial.println("");
		}
	}

}
