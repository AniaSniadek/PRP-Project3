<?php
// required headers
header("Access-Control-Allow-Origin: *");
header("Content-Type: application/json; charset=UTF-8");
 
// database connection
// include database and object files
include_once '../config/database.php';
include_once '../obiekty/zespol.php';
 
// instantiate database and product object
$database = new Database();
$db = $database->getConnection();
 
// initialize object
$zespol = new Zespol($db);
 
// read zespol
// query zespol
$stmt = $zespol->read();
$num = $stmt->rowCount();

// check if more than 0 record found
if($num>0){

	// zespol array
    $zespol_arr=array();
    $zespol_arr["records"]=array();

    // retrieve our table contents
    while ($row = $stmt->fetch(PDO::FETCH_ASSOC)){
        // extract row
        // this will make $row['name'] to
        // just $name only
        extract($row);

        $zespol_item=array(
            "zespol_id" => $zespol_id,
            "nazwa" => $nazwa
        );

        array_push($zespol_arr["records"], $zespol_item);
    }

    // set response code - 200 OK
    http_response_code(200);
 
    // show products data in json format
    echo json_encode($zespol_arr);
}

// no products found 
else{
 
    // set response code - 404 Not found
    http_response_code(404);
 
    // tell the user no products found
    echo json_encode(
        array("message" => "Nie znaleziono zadnego zespolu.")
    );
}
?>
