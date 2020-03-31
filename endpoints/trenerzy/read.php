<?php
header("Access-Control-Allow-Origin: *");
header("Content-Type: application/json; charset=UTF-8");
 
include_once '../config/database.php';
include_once '../obiekty/trenerzy.php';
 
$database = new Database();
$db = $database->getConnection();
 
$trenerzy = new Trener($db);

$stmt = $trenerzy->read();
$num = $stmt->rowCount();

if($num>0){

    $trenerzy_arr=array();
    $trenerzy_arr["records"]=array();

    while ($row = $stmt->fetch(PDO::FETCH_ASSOC)){

        extract($row);

        $trenerzy_item=array(
            "trener_id" => $trener_id,
            "nazwisko" => $nazwisko
        );

        array_push($trenerzy_arr["records"], $trenerzy_item);
    }

    http_response_code(200);
    echo json_encode($trenerzy_arr);
}

else{
 
    http_response_code(404);
 
    echo json_encode(
        array("message" => "Nie znaleziono zadnego trenera.")
    );
}
?>
