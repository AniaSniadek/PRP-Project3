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
 
// get posted data
$data = json_decode(file_get_contents("php://input"));
 
// make sure data is not empty
if(
    !empty($data->zespol_id) &&
    !empty($data->nazwa)
){
    // set product property values
    $zespol->zespol_id = $data->zespol_id;
    $zespol->nazwa = $data->nazwa;
 
    // create the product
    if($zespol->create()){
 
        http_response_code(201);
        echo json_encode(array("message" => "Zespol zostal dodany."));
    }
 
    // if unable to create the product, tell the user
    else{
 
        http_response_code(503);
        echo json_encode(array("message" => "Nie mozna dodac zespolu."));
    }
}
 
// tell the user data is incomplete
else{
 
    http_response_code(400);
    echo json_encode(array("message" => "Nie mozna dodac zespolu."));
}
?>