<?php
header("Access-Control-Allow-Origin: *");
header("Content-Type: application/json; charset=UTF-8");
header("Access-Control-Allow-Methods: POST");
header("Access-Control-Max-Age: 3600");
header("Access-Control-Allow-Headers: Content-Type, Access-Control-Allow-Headers, Authorization, X-Requested-With");

include_once '../config/database.php';
include_once '../obiekty/prezes.php';

$database = new Database();
$db = $database->getConnection();

$prezes = new Prezes($db);

$data = json_decode(file_get_contents("php://input"));

$prezes->prezes_id = $data->prezes_id;

if($prezes->delete()){

    http_response_code(200);

    echo json_encode(array("message" => "Prezes zostal usuniety."));
}

else{

    http_response_code(503);

    echo json_encode(array("message" => "Nie mozna usunac prezesa."));
}
?>