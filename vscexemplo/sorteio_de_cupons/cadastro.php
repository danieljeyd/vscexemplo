<?php
$nomeCliente = $_POST['nomeCliente'];
$telefone = $_POST['phone'];
$email = $_POST['email'];
$observacao = $_POST['textoCliente'];

$strcon = mysqli_connect('localhost', 'root', '1234','jeyd') or die ('Erro ao conexão');
$sql = "INSERT INTO cadastro VALUES ";
echo "Cliente cadastrado com sucesso!";
$sql .= "('$nomeCliente', '$telefone', '$email', '$observacao')";
mysqli_query( $strcon, $sql ) or die (" Erro ao tentar cadastrar registro");
mysqli_close($strcon);

?>