<?php
header("Access-Control-Allow-Origin: *");
header("Content-Type: application/json; charset=UTF-8");
header("Access-Control-Allow-Methods: POST");
header("Access-Control-Max-Age: 3600");
header("Access-Control-Allow-Headers: Content-Type, Access-Control-Allow-Headers, Authorization, X-Requested-With");

include_once '../config/database.php';
include_once '../obiekty/zespol.php';

$database = new Database();
$db = $database->getConnection();

$zespol = new Zespol($db);
 
// get id of product to be edited
$data = json_decode(file_get_contents("php://input"));
 
// set product property values
$zespol->zespol_id = $data->zespol_id;
$zespol->nazwa = $data->nazwa;
 
// edit the product
if($zespol->edit()){
 
    http_response_code(200);

    echo json_encode(array("message" => "Zespol zostal edytowany."));
}

else{
 
    http_response_code(503);
 
    echo json_encode(array("message" => "Nie mozna edytowac zespolu."));
}
?>