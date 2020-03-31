<?php
header("Access-Control-Allow-Origin: *");
header("Content-Type: application/json; charset=UTF-8");
 
include_once '../config/database.php';
include_once '../obiekty/zawodnicy.php';
 
$database = new Database();
$db = $database->getConnection();
 
$zawodnicy = new Zawodnik($db);

$stmt = $zawodnicy->read();
$num = $stmt->rowCount();

if($num>0){

    $zawodnicy_arr=array();
    $zawodnicy_arr["records"]=array();

    while ($row = $stmt->fetch(PDO::FETCH_ASSOC)){

        extract($row);

        $zawodnicy_item=array(
            "zawodnik_id" => $zawodnik_id,
            "nazwisko" => $nazwisko,
            "numer" => $numer,
            "data_urodzin" => $data_urodzin
        );

        array_push($zawodnicy_arr["records"], $zawodnicy_item);
    }

    http_response_code(200);
    echo json_encode($zawodnicy_arr);
}

else{
 
    http_response_code(404);
 
    echo json_encode(
        array("message" => "Nie znaleziono zadnego zawodnika.")
    );
}
?>
