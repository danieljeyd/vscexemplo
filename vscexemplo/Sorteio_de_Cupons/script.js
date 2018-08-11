function myFunction() {
    var x = Math.floor((Math.random() * 10) + 1);
    var greeting;

    alert("clique para abrir o pacote");

    if (x == 2) {
        greeting = "Parabéns você ganhou cupom de 10% codigo: #desonto10";

    }
    else {
        greeting = " Infelizmente não foi desta vez, quer tentar novamente preencha os campos"
    }
    document.getElementById("demo").innerHTML = greeting;

}


function salvar() {
// função mostrar botão
    $(document).ready(function () {
        $("#hide").click(function () {
           
            $(hide).show();

        });
    });
    document.getElementById('conteudo').document.designMode = 'On';
    var conteudo = '';

    conteudo += "Nome: " + document.getElementById('nome').value + "<br>";
    conteudo += "Sobrenome: " + document.getElementById('sobrenome').value + "<br>";

    frames['conteudo'].document.body.innerHTML = conteudo;

    frames['conteudo'].document.execCommand('SaveAs', false, 'arquivo.txt');
}
