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

$trenerzy->trener_id = $data->trener_id;
$trenerzy->nazwisko = $data->nazwisko;

if($trenerzy->edit()){
 
    http_response_code(200);

    echo json_encode(array("message" => "Trener zostal edytowany."));
}

else{
 
    http_response_code(503);
 
    echo json_encode(array("message" => "Nie mozna edytowac trenera."));
}
?>