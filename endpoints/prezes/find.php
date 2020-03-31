<?php
header("Access-Control-Allow-Origin: *");
header("Access-Control-Allow-Headers: access");
header("Access-Control-Allow-Methods: GET");
header("Access-Control-Allow-Credentials: true");
header('Content-Type: application/json');

include_once '../config/database.php';
include_once '../obiekty/prezes.php';

$database = new Database();
$db = $database->getConnection();

$prezes = new Prezes($db);

$prezes->prezes_id = isset($_GET['id']) ? $_GET['id'] : die();

$prezes->find();
 
if($prezes->nazwisko!=null){
    
    $prezes_arr = array(
        "prezes_id" =>  $prezes->prezes_id,
        "nazwisko" => $prezes->nazwisko,
        "email" => $prezes->email
    );
 
    http_response_code(200);
    echo json_encode($prezes_arr);
}
 
else{

    http_response_code(404);
    echo json_encode(array("message" => "Prezes o podanym id nie istnieje."));
}
?>