<?php
class Trener{

    private $conn;
    private $table_name = "trenerzy";

    public $trener_id;
    public $nazwisko;

    public function __construct($db){
    	$this->conn = $db;
    }

	function read(){
	 
	    $query = "SELECT
	                trener_id, nazwisko
	            FROM
	            	" . $this->table_name . "
	            ORDER BY
	            	nazwisko";
	 
	    $stmt = $this->conn->prepare($query);
	    $stmt->execute();
	 
	    return $stmt;
	}

	function create(){
	 
	    $query = "INSERT INTO
	                " . $this->table_name . "
	            SET
	                trener_id=:trener_id, nazwisko=:nazwisko";
	 
	    $stmt = $this->conn->prepare($query);
	 
	    $this->trener_id=htmlspecialchars(strip_tags($this->trener_id));
	    $this->nazwisko=htmlspecialchars(strip_tags($this->nazwisko));
	 
	    $stmt->bindParam(":trener_id", $this->trener_id);
	    $stmt->bindParam(":nazwisko", $this->nazwisko);
	 
	    if($stmt->execute()){
	        return true;
	    }
	    
	    return false;  
	}

	function find(){
 
	    $query = "SELECT
	                trener_id, nazwisko
	            FROM
	                " . $this->table_name . "
	            WHERE
	                trener_id = ?
	            LIMIT
	                0,1";
	 
	    $stmt = $this->conn->prepare( $query );
	 
	    $stmt->bindParam(1, $this->trener_id);
	 
	    $stmt->execute();
	 
	    $row = $stmt->fetch(PDO::FETCH_ASSOC);
	 
	    $this->trener_id = $row['trener_id'];
	    $this->nazwisko = $row['nazwisko'];
	}

	function edit(){
	
	    $query = "UPDATE
	                " . $this->table_name . "
	            SET
	                nazwisko = :nazwisko
	            WHERE
	                trener_id = :trener_id";
	 
	    $stmt = $this->conn->prepare($query);
	 
	    $this->trener_id=htmlspecialchars(strip_tags($this->trener_id));
	    $this->nazwisko=htmlspecialchars(strip_tags($this->nazwisko));
	 
	    $stmt->bindParam(':trener_id', $this->trener_id);
	    $stmt->bindParam(':nazwisko', $this->nazwisko);
	 
	    if($stmt->execute()){
	        return true;
	    }
	 
	    return false;
	}

	function delete(){

	    $query = "DELETE FROM " . $this->table_name . " WHERE trener_id = ?";

	    $stmt = $this->conn->prepare($query);

	    $this->trener_id=htmlspecialchars(strip_tags($this->trener_id));

	    $stmt->bindParam(1, $this->trener_id);

	    if($stmt->execute()){
	        return true;
	    }
	 
	    return false;    
	}
}
?>