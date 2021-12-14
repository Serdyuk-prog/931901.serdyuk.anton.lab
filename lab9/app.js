const inputPenel = document.querySelector("#input");
const buttons = document.querySelectorAll("button");
let isExpressionClear = true;
let isOperationDefined = false;

buttons.forEach((btn) => {
    btn.addEventListener("click", () => {
        actionHandler(btn.dataset.label);
    });
})

function actionHandler(data) {
    switch (data) {
        case 'C':
            clearHandler();
            break;
        case 'bsp':
            bspHandler();
            break;
        case '=':
            equalHandler();
            break;
        default:
            inputHandler(data);
    }
}

// function clearHandler() {
//     inputPenel.innerText = "0";
//     isExpressionClear = true;
//     isOperationDefined = false;
// }

// function bspHandler() {
//     if (isNumber(inputPenel.innerText.substr(-1))) {
//         inputPenel.innerText = inputPenel.innerText.substring(0, inputPenel.innerText.length - 1);
//     } else {
//         inputPenel.innerText = inputPenel.innerText.substring(0, inputPenel.innerText.length - 3);
//         isOperationDefined = false;
//     }

//     if (inputPenel.innerText == "") {
//         inputPenel.innerText = "0";
//         isExpressionClear = true;
//     }
// }

// function equalHandler() {
//     inputPenel.innerText = eval(inputPenel.innerText);
//     isExpressionClear = true;
//     isOperationDefined = false;
// }

// function inputHandler(char) {
//     if (isExpressionClear) {
//         inputPenel.innerText = "";
//         isExpressionClear = false;
//         if (!isNumber(char)) {
//             inputPenel.innerText = "0";
//         }
//     }

//     if (isNumber(char)) {
//         inputPenel.innerText = inputPenel.innerText + char;
//     } else if (!isOperationDefined) {
//         inputPenel.innerText = inputPenel.innerText + "\xa0" + char + "\xa0";
//         isOperationDefined = true;
//     } else {
//         if (isNumber(inputPenel.innerText.substr(-1))) {
//             equalHandler();
//             inputPenel.innerText = inputPenel.innerText + "\xa0" + char + "\xa0";
//             isOperationDefined = true;
//             isExpressionClear = false;
//         } else {
//             inputPenel.innerText = inputPenel.innerText.substring(0, inputPenel.innerText.length - 3);
//             inputPenel.innerText = inputPenel.innerText + "\xa0" + char + "\xa0";
//         }
//     }
// }

function isNumber(char) {
    if (char >= '0' && char <= '9') {
        return true;
    } else {
        return false;
    }
}