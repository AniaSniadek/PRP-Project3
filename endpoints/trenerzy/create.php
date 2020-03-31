<?php
header("Access-Control-Allow-Origin: *");
header("Content-Type: application/json; charset=UTF-8");
header("Access-Control-Allow-Methods: POST");
header("Access-Control-Max-Age: 3600");
header("Access-Control-Allow-Headers: Content-Type, Access-Control-Allow-Headers, Authorization, X-Requested-With");

include_once '../config/database.php';
include_once '../obiekty/trenerzy.php';
 
$database = new Database();
$db = $database->getConnection();
 
$trenerzy = new Trener($db);

$data = json_decode(file_get_contents("php://input"));

if(
    !empty($data->trener_id) &&
    !empty($data->nazwisko)
){
    $trenerzy->trener_id = $data->trener_id;
    $trenerzy->nazwisko = $data->nazwisko;

    if($trenerzy->create()){
 
        http_response_code(201);
        echo json_encode(array("message" => "Trener zostal dodany."));
    }
 
    else{
 
        http_response_code(503);
        echo json_encode(array("message" => "Nie mozna dodac trenera."));
    }
}

else{
 
    http_response_code(400);
    echo json_encode(array("message" => "Nie mozna dodac trenera."));
}
?>