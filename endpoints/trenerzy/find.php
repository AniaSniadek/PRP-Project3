<?php
header("Access-Control-Allow-Origin: *");
header("Access-Control-Allow-Headers: access");
header("Access-Control-Allow-Methods: GET");
header("Access-Control-Allow-Credentials: true");
header('Content-Type: application/json');

include_once '../config/database.php';
include_once '../obiekty/trenerzy.php';

$database = new Database();
$db = $database->getConnection();

$trenerzy = new Trener($db);

$trenerzy->trener_id = isset($_GET['id']) ? $_GET['id'] : die();

$trenerzy->find();
 
if($trenerzy->nazwisko!=null){
    
    $trenerzy_arr = array(
        "trener_id" =>  $trenerzy->trener_id,
        "nazwisko" => $trenerzy->nazwisko
    );
 
    http_response_code(200);
    echo json_encode($trenerzy_arr);
}
 
else{

    http_response_code(404);
    echo json_encode(array("message" => "Trener o podanym id nie istnieje."));
}
?>