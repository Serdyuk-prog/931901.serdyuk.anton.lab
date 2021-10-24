const buttons = document.querySelectorAll("button");

const leftImg = document.querySelector("#left-img");
const rightImg = document.querySelector("#right-img");

buttons.forEach(btn => {
    btn.onclick = () => {
        switch (btn.id) {
            case 'left-btn':
                leftImg.style.width = '95%';
                rightImg.style.width = '5%';
                leftImg.querySelector("img").style.display = 'block';
                rightImg.querySelector("img").style.display = 'none';
                break;
            case 'center-btn':
                leftImg.style.width = '50%';
                rightImg.style.width = '50%';
                leftImg.querySelector("img").style.display = 'block';
                rightImg.querySelector("img").style.display = 'block';
                break;
            case 'right-btn':
                leftImg.style.width = '5%';
                rightImg.style.width = '95%';
                leftImg.querySelector("img").style.display = 'none';
                rightImg.querySelector("img").style.display = 'block';
                break;
        }
    }
})