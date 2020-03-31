<?php
class Zawodnik{

    private $conn;
    private $table_name = "zawodnicy";

    public $zawodnik_id;
    public $nazwisko;
    public $numer;
    public $data_urodzin;

    public function __construct($db){
    	$this->conn = $db;
    }

	function read(){
	 
	    $query = "SELECT
	                zawodnik_id, nazwisko, numer, data_urodzin
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
	                zawodnik_id=:zawodnik_id, nazwisko=:nazwisko, numer=:numer, data_urodzin=:data_urodzin";
	 
	    $stmt = $this->conn->prepare($query);
	 
	    $this->zawodnik_id=htmlspecialchars(strip_tags($this->zawodnik_id));
	    $this->nazwisko=htmlspecialchars(strip_tags($this->nazwisko));
	    $this->numer=htmlspecialchars(strip_tags($this->numer));
	    $this->data_urodzin=htmlspecialchars(strip_tags($this->data_urodzin));
	 
	    $stmt->bindParam(":zawodnik_id", $this->zawodnik_id);
	    $stmt->bindParam(":nazwisko", $this->nazwisko);
	    $stmt->bindParam(":numer", $this->numer);
	    $stmt->bindParam(":data_urodzin", $this->data_urodzin);
	 
	    if($stmt->execute()){
	        return true;
	    }
	    
	    return false;  
	}

	function find(){
 
	    $query = "SELECT
	                zawodnik_id, nazwisko, numer, data_urodzin
	            FROM
	                " . $this->table_name . "
	            WHERE
	                zawodnik_id = ?
	            LIMIT
	                0,1";
	 
	    $stmt = $this->conn->prepare( $query );
	 
	    $stmt->bindParam(1, $this->zawodnik_id);
	 
	    $stmt->execute();
	 
	    $row = $stmt->fetch(PDO::FETCH_ASSOC);
	 
	    $this->zawodnik_id = $row['zawodnik_id'];
	    $this->nazwisko = $row['nazwisko'];
	    $this->numer = $row['numer'];
	    $this->data_urodzin = $row['data_urodzin'];
	}

	function edit(){
	
	    $query = "UPDATE
	                " . $this->table_name . "
	            SET
	                nazwisko = :nazwisko,
	                numer = :numer,
	                data_urodzin = :data_urodzin
	            WHERE
	                zawodnik_id = :zawodnik_id";
	 
	    $stmt = $this->conn->prepare($query);
	 
	    $this->zawodnik_id=htmlspecialchars(strip_tags($this->zawodnik_id));
	    $this->nazwisko=htmlspecialchars(strip_tags($this->nazwisko));
	    $this->numer=htmlspecialchars(strip_tags($this->numer));
	    $this->data_urodzin=htmlspecialchars(strip_tags($this->data_urodzin));
	 
	    $stmt->bindParam(':zawodnik_id', $this->zawodnik_id);
	    $stmt->bindParam(':nazwisko', $this->nazwisko);
	    $stmt->bindParam(':numer', $this->numer);
	    $stmt->bindParam(':data_urodzin', $this->data_urodzin);
	 
	    if($stmt->execute()){
	        return true;
	    }
	 
	    return false;
	}

	function delete(){

	    $query = "DELETE FROM " . $this->table_name . " WHERE zawodnik_id = ?";

	    $stmt = $this->conn->prepare($query);

	    $this->zawodnik_id=htmlspecialchars(strip_tags($this->zawodnik_id));

	    $stmt->bindParam(1, $this->zawodnik_id);

	    if($stmt->execute()){
	        return true;
	    }
	 
	    return false;    
	}

}
?>