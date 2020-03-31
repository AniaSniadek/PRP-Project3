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

$hala->hala_id = $data->hala_id;
$hala->nazwa = $data->nazwa;

if($hala->edit()){
 
    http_response_code(200);

    echo json_encode(array("message" => "Hala zostala edytowana."));
}

else{
 
    http_response_code(503);
 
    echo json_encode(array("message" => "Nie mozna edytowac hali."));
}
?>