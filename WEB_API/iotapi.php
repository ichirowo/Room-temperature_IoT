<?php

	date_default_timezone_set('Asia/Tokyo');
	$today = date("Y-m-d H:i:s");
	$filename = "IoTdata.txt";

	$MachineName = $_POST["MachineName"];
	$Temperature = $_POST["Temperature"];
	$Humidity = $_POST["Humidity"];

	$data = sprintf("%s,%s,%s,%s", $today, $MachineName, $Temperature, $Humidity);
	
	if(file_put_contents($filename,$data,FILE_APPEND) != false){
		echo "OK";
	}

?>