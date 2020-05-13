<?php
    $name = filter_var(trim($_POST['name']), FILTER_SANITIZE_STRING);
    $surname = filter_var(trim($_POST['surname']), FILTER_SANITIZE_STRING);
    
    
    ini_set('mysql.connect_timeout', 300);
    ini_set('default_socket_timeout', 300);
    
    $mysql = new mysqli('localhost', 'id13668343_faridun', '|Zl^Q8!P{R*ANxyU', 'id13668343_sendysocialclub');
    if (mysqli_connect_errno($mysql))
    {
        echo "Failed to connect to MySQL: " . mysqli_connect_error();
    }
    else
    {
        echo "OK"; 
    }
    
    $mysql->query("INSERT INTO `User` (`Name`, `Surname`) VALUES('$name', '$surname')");
    $mysql->close();
?>