<?php
header("Access-Control-Allow-Origin: *");
header("Content-Type: application/json; charset=UTF-8");
 
include_once '../config/database.php';
include_once '../obiekty/prezes.php';
 
$database = new Database();
$db = $database->getConnection();
 
$prezes = new Prezes($db);

$stmt = $prezes->read();
$num = $stmt->rowCount();

if($num>0){

    $prezes_arr=array();
    $prezes_arr["records"]=array();

    while ($row = $stmt->fetch(PDO::FETCH_ASSOC)){

        extract($row);

        $prezes_item=array(
            "prezes_id" => $prezes_id,
            "nazwisko" => $nazwisko,
            "email" => $email
        );

        array_push($prezes_arr["records"], $prezes_item);
    }

    http_response_code(200);
    echo json_encode($prezes_arr);
}

else{
 
    http_response_code(404);
 
    echo json_encode(
        array("message" => "Nie znaleziono zadnego prezesa.")
    );
}
?>
