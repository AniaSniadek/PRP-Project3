<?php
class Hala{

    private $conn;
    private $table_name = "hala";

    public $hala_id;
    public $nazwa;

    public function __construct($db){
    	$this->conn = $db;
    }

	function read(){
	 
	    $query = "SELECT
	                hala_id, nazwa
	            FROM
	            	" . $this->table_name . "
	            ORDER BY
	            	nazwa";
	 
	    $stmt = $this->conn->prepare($query);
	    $stmt->execute();
	 
	    return $stmt;
	}

	function create(){
	 
	    $query = "INSERT INTO
	                " . $this->table_name . "
	            SET
	                hala_id=:hala_id, nazwa=:nazwa";
	 
	    $stmt = $this->conn->prepare($query);
	 
	    $this->hala_id=htmlspecialchars(strip_tags($this->hala_id));
	    $this->nazwa=htmlspecialchars(strip_tags($this->nazwa));
	 
	    $stmt->bindParam(":hala_id", $this->hala_id);
	    $stmt->bindParam(":nazwa", $this->nazwa);
	 
	    if($stmt->execute()){
	        return true;
	    }
	    
	    return false;  
	}

	function find(){
 
	    $query = "SELECT
	                hala_id, nazwa
	            FROM
	                " . $this->table_name . "
	            WHERE
	                hala_id = ?
	            LIMIT
	                0,1";
	 
	    $stmt = $this->conn->prepare( $query );
	 
	    $stmt->bindParam(1, $this->hala_id);
	 
	    $stmt->execute();
	 
	    $row = $stmt->fetch(PDO::FETCH_ASSOC);
	 
	    $this->hala_id = $row['hala_id'];
	    $this->nazwa = $row['nazwa'];
	}

	function edit(){
	
	    $query = "UPDATE
	                " . $this->table_name . "
	            SET
	                nazwa = :nazwa
	            WHERE
	                hala_id = :hala_id";
	 
	    $stmt = $this->conn->prepare($query);
	 
	    $this->hala_id=htmlspecialchars(strip_tags($this->hala_id));
	    $this->nazwa=htmlspecialchars(strip_tags($this->nazwa));
	 
	    $stmt->bindParam(':hala_id', $this->hala_id);
	    $stmt->bindParam(':nazwa', $this->nazwa);
	 
	    if($stmt->execute()){
	        return true;
	    }
	 
	    return false;
	}

	function delete(){

	    $query = "DELETE FROM " . $this->table_name . " WHERE hala_id = ?";

	    $stmt = $this->conn->prepare($query);

	    $this->hala_id=htmlspecialchars(strip_tags($this->hala_id));

	    $stmt->bindParam(1, $this->hala_id);

	    if($stmt->execute()){
	        return true;
	    }
	 
	    return false;    
	}

}
?>