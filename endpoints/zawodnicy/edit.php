<?php
header("Access-Control-Allow-Origin: *");
header("Content-Type: application/json; charset=UTF-8");
header("Access-Control-Allow-Methods: POST");
header("Access-Control-Max-Age: 3600");
header("Access-Control-Allow-Headers: Content-Type, Access-Control-Allow-Headers, Authorization, X-Requested-With");

include_once '../config/database.php';
include_once '../obiekty/zawodnicy.php';

$database = new Database();
$db = $database->getConnection();

$zawodnicy = new Zawodnik($db);

$data = json_decode(file_get_contents("php://input"));

$zawodnicy->zawodnik_id = $data->zawodnik_id;
$zawodnicy->nazwisko = $data->nazwisko;
$zawodnicy->numer = $data->numer;
$zawodnicy->data_urodzin= $data->data_urodzin;

if($zawodnicy->edit()){
 
    http_response_code(200);

    echo json_encode(array("message" => "Zawodnik zostal edytowany."));
}

else{
 
    http_response_code(503);
 
    echo json_encode(array("message" => "Nie mozna edytowac zawodnika."));
}
?>