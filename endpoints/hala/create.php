<?php
header("Access-Control-Allow-Origin: *");
header("Content-Type: application/json; charset=UTF-8");
header("Access-Control-Allow-Methods: POST");
header("Access-Control-Max-Age: 3600");
header("Access-Control-Allow-Headers: Content-Type, Access-Control-Allow-Headers, Authorization, X-Requested-With");

include_once '../config/database.php';
include_once '../obiekty/hala.php';
 
$database = new Database();
$db = $database->getConnection();
 
$hala = new Hala($db);

$data = json_decode(file_get_contents("php://input"));

if(
    !empty($data->hala_id) &&
    !empty($data->nazwa)
){
    $hala->hala_id = $data->hala_id;
    $hala->nazwa = $data->nazwa;

    if($hala->create()){
 
        http_response_code(201);
        echo json_encode(array("message" => "Hala zostala dodana."));
    }
 
    else{
 
        http_response_code(503);
        echo json_encode(array("message" => "Nie mozna dodac hali."));
    }
}

else{
 
    http_response_code(400);
    echo json_encode(array("message" => "Nie mozna dodac hali."));
}
?>