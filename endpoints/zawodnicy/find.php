<?php
header("Access-Control-Allow-Origin: *");
header("Access-Control-Allow-Headers: access");
header("Access-Control-Allow-Methods: GET");
header("Access-Control-Allow-Credentials: true");
header('Content-Type: application/json');

include_once '../config/database.php';
include_once '../obiekty/zawodnicy.php';

$database = new Database();
$db = $database->getConnection();

$zawodnicy = new Zawodnik($db);

$zawodnicy->zawodnik_id = isset($_GET['id']) ? $_GET['id'] : die();

$zawodnicy->find();
 
if($zawodnicy->nazwisko!=null){
    
    $zawodnicy_arr = array(
        "zawodnik_id" =>  $zawodnicy->zawodnik_id,
        "nazwisko" => $zawodnicy->nazwisko,
        "numer" => $zawodnicy->numer,
        "data_urodzin" => $zawodnicy->data_urodzin
    );
 
    http_response_code(200);
    echo json_encode($zawodnicy_arr);
}
 
else{

    http_response_code(404);
    echo json_encode(array("message" => "Zawodnik o podanym id nie istnieje."));
}
?>