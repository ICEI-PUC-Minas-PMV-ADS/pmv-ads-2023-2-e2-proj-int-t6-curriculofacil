// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
//JS da parte de busca
function search() {
    var input, filter, cards, card, title, description, item1, item2, i;
    input = document.getElementById('search');
    filter = input.value.toUpperCase();
    cards = document.getElementsByClassName('card');

    for (i = 0; i < cards.length; i++) {
        card = cards[i];
        title = card.getElementsByClassName('card-body')[0];
        description = card.getElementsByClassName('card-objective')[0];
        item1 = card.getElementsByClassName('estado')[0];
        item2 = card.getElementsByClassName('cidade')[0];
        if (
            title.innerHTML.toUpperCase().indexOf(filter) > -1 ||
            description.innerHTML.toUpperCase().indexOf(filter) > -1 ||
            item1.innerHTML.toUpperCase().indexOf(filter) > -1 ||
            item2.innerHTML.toUpperCase().indexOf(filter) > -1
        ) {
            card.style.display = '';
        } else {
            card.style.display = 'none';
        }
    }
}

// JS parte de download do currículo
const btnGenerate = document.querySelector("#generate-pdf");

btnGenerate.addEventListener("click", () => {
    // Conteúdo do PDF
    const content = document.querySelector("#content");

    // Configuração do arquivo final PDF
    const options = {
        margin: [10, 10, 10, 10],
        filename: "Curriculo.pdf",
        html2canvas: { scale: 2 },
        jsPDF: { unit: "mm", format: "a4", orientation: "portrait" }
    };

    console.log("testes");

    // Gerar e baixar o PDF
    //window.html2pdf().set(options).from(content).save();
    html2pdf().set(options).from(content).save();
});