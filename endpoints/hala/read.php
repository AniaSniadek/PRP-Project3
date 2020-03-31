<?php
header("Access-Control-Allow-Origin: *");
header("Content-Type: application/json; charset=UTF-8");
 
include_once '../config/database.php';
include_once '../obiekty/hala.php';
 
$database = new Database();
$db = $database->getConnection();
 
$hala = new Hala($db);

$stmt = $hala->read();
$num = $stmt->rowCount();

if($num>0){

    $hala_arr=array();
    $hala_arr["records"]=array();

    while ($row = $stmt->fetch(PDO::FETCH_ASSOC)){

        extract($row);

        $hala_item=array(
            "hala_id" => $hala_id,
            "nazwa" => $nazwa
        );

        array_push($hala_arr["records"], $hala_item);
    }

    http_response_code(200);
    echo json_encode($hala_arr);
}

else{
 
    http_response_code(404);
 
    echo json_encode(
        array("message" => "Nie znaleziono zadnej hali.")
    );
}
?>
