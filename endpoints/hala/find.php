<?php
header("Access-Control-Allow-Origin: *");
header("Access-Control-Allow-Headers: access");
header("Access-Control-Allow-Methods: GET");
header("Access-Control-Allow-Credentials: true");
header('Content-Type: application/json');

include_once '../config/database.php';
include_once '../obiekty/hala.php';

$database = new Database();
$db = $database->getConnection();

$hala = new Hala($db);

$hala->hala_id = isset($_GET['id']) ? $_GET['id'] : die();

$hala->find();
 
if($hala->nazwa!=null){
    
    $hala_arr = array(
        "hala_id" =>  $hala->hala_id,
        "nazwa" => $hala->nazwa
    );
 
    http_response_code(200);
    echo json_encode($hala_arr);
}
 
else{

    http_response_code(404);
    echo json_encode(array("message" => "Hala o podanym id nie istnieje."));
}
?>