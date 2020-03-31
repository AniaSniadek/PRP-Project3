<?php
header("Access-Control-Allow-Origin: *");
header("Access-Control-Allow-Headers: access");
header("Access-Control-Allow-Methods: GET");
header("Access-Control-Allow-Credentials: true");
header('Content-Type: application/json');

include_once '../config/database.php';
include_once '../obiekty/zespol.php';

$database = new Database();
$db = $database->getConnection();

$zespol = new Zespol($db);
 
// set ID property of record to read
$zespol->zespol_id = isset($_GET['id']) ? $_GET['id'] : die();
 
// read the details of product to be edited
$zespol->find();
 
if($zespol->nazwa!=null){
    // create array
    $zespol_arr = array(
        "zespol_id" =>  $zespol->zespol_id,
        "nazwa" => $zespol->nazwa
    );
 
    http_response_code(200);
    echo json_encode($zespol_arr);
}
 
else{

    http_response_code(404);
    echo json_encode(array("message" => "Zespol o podanym id nie istnieje."));
}
?>