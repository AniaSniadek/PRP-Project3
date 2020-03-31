<?php
class Zespol{

	// database connection and table name
    private $conn;
    private $table_name = "zespol";

    // object properties
    public $zespol_id;
    public $nazwa;

    // constructor with $db as database connection
    public function __construct($db){
    	$this->conn = $db;
    }

	// read products
	function read(){
	 
	    // select all query
	    $query = "SELECT
	                zespol_id, nazwa
	            FROM
	            	" . $this->table_name . "
	            ORDER BY
	            	nazwa";
	 
	    // prepare query statement
	    $stmt = $this->conn->prepare($query);
	 
	    // execute query
	    $stmt->execute();
	 
	    return $stmt;
	}

	// create product
	function create(){
	 
	    // query to insert record
	    $query = "INSERT INTO
	                " . $this->table_name . "
	            SET
	                zespol_id=:zespol_id, nazwa=:nazwa";
	 
	    // prepare query
	    $stmt = $this->conn->prepare($query);
	 
	    // sanitize
	    $this->zespol_id=htmlspecialchars(strip_tags($this->zespol_id));
	    $this->nazwa=htmlspecialchars(strip_tags($this->nazwa));
	 
	    // bind values
	    $stmt->bindParam(":zespol_id", $this->zespol_id);
	    $stmt->bindParam(":nazwa", $this->nazwa);
	 
	    // execute query
	    if($stmt->execute()){
	        return true;
	    }
	    
	    return false;  
	}

	function find(){
 
	    // query to read single record
	    $query = "SELECT
	                zespol_id, nazwa
	            FROM
	                " . $this->table_name . "
	            WHERE
	                zespol_id = ?
	            LIMIT
	                0,1";
	 
	    // prepare query statement
	    $stmt = $this->conn->prepare( $query );
	 
	    // bind id of product to be updated
	    $stmt->bindParam(1, $this->zespol_id);
	 
	    // execute query
	    $stmt->execute();
	 
	    // get retrieved row
	    $row = $stmt->fetch(PDO::FETCH_ASSOC);
	 
	    // set values to object properties
	    $this->zespol_id = $row['zespol_id'];
	    $this->nazwa = $row['nazwa'];
	}

	// edit the product
	function edit(){
	 
	    // update query
	    $query = "UPDATE
	                " . $this->table_name . "
	            SET
	                nazwa = :nazwa
	            WHERE
	                zespol_id = :zespol_id";
	 
	    // prepare query statement
	    $stmt = $this->conn->prepare($query);
	 
	    // sanitize
	    $this->zespol_id=htmlspecialchars(strip_tags($this->zespol_id));
	    $this->nazwa=htmlspecialchars(strip_tags($this->nazwa));
	 
	    // bind new values
	    $stmt->bindParam(':zespol_id', $this->zespol_id);
	    $stmt->bindParam(':nazwa', $this->nazwa);
	 
	    // execute the query
	    if($stmt->execute()){
	        return true;
	    }
	 
	    return false;
	}

	// delete the product
	function delete(){

	    $query = "DELETE FROM " . $this->table_name . " WHERE zespol_id = ?";

	    $stmt = $this->conn->prepare($query);

	    $this->zespol_id=htmlspecialchars(strip_tags($this->zespol_id));

	    $stmt->bindParam(1, $this->zespol_id);

	    if($stmt->execute()){
	        return true;
	    }
	 
	    return false;    
	}
}
?>