<?php
class Prezes{

    private $conn;
    private $table_name = "prezes";

    public $prezes_id;
    public $nazwisko;
    public $email;

    public function __construct($db){
    	$this->conn = $db;
    }

	function read(){
	 
	    $query = "SELECT
	                prezes_id, nazwisko, email
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
	                prezes_id=:prezes_id, nazwisko=:nazwisko, email=:email";
	 
	    $stmt = $this->conn->prepare($query);
	 
	    $this->prezes_id=htmlspecialchars(strip_tags($this->prezes_id));
	    $this->nazwisko=htmlspecialchars(strip_tags($this->nazwisko));
	    $this->email=htmlspecialchars(strip_tags($this->email));
	 
	    $stmt->bindParam(":prezes_id", $this->prezes_id);
	    $stmt->bindParam(":nazwisko", $this->nazwisko);
	    $stmt->bindParam(":email", $this->email);
	 
	    if($stmt->execute()){
	        return true;
	    }
	    
	    return false;  
	}

	function find(){
 
	    $query = "SELECT
	                prezes_id, nazwisko, email
	            FROM
	                " . $this->table_name . "
	            WHERE
	                prezes_id = ?
	            LIMIT
	                0,1";
	 
	    $stmt = $this->conn->prepare( $query );
	 
	    $stmt->bindParam(1, $this->prezes_id);
	 
	    $stmt->execute();
	 
	    $row = $stmt->fetch(PDO::FETCH_ASSOC);
	 
	    $this->prezes_id = $row['prezes_id'];
	    $this->nazwisko = $row['nazwisko'];
	    $this->email = $row['email'];
	}

	function edit(){
	
	    $query = "UPDATE
	                " . $this->table_name . "
	            SET
	                nazwisko = :nazwisko,
	                email = :email
	            WHERE
	                prezes_id = :prezes_id";
	 
	    $stmt = $this->conn->prepare($query);
	 
	    $this->prezes_id=htmlspecialchars(strip_tags($this->prezes_id));
	    $this->nazwisko=htmlspecialchars(strip_tags($this->nazwisko));
	    $this->email=htmlspecialchars(strip_tags($this->email));
	 
	    $stmt->bindParam(':prezes_id', $this->prezes_id);
	    $stmt->bindParam(':nazwisko', $this->nazwisko);
	    $stmt->bindParam(':email', $this->email);
	 
	    if($stmt->execute()){
	        return true;
	    }
	 
	    return false;
	}

	function delete(){

	    $query = "DELETE FROM " . $this->table_name . " WHERE prezes_id = ?";

	    $stmt = $this->conn->prepare($query);

	    $this->prezes_id=htmlspecialchars(strip_tags($this->prezes_id));

	    $stmt->bindParam(1, $this->prezes_id);

	    if($stmt->execute()){
	        return true;
	    }
	 
	    return false;    
	}
}
?>