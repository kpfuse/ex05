const datetimeElement = document.getElementById("datetime");

function updateTime() {
    const now = new Date();
    datetimeElement.textContent = now.toLocaleString();
}

updateTime();// Обновить сразу
setInterval(updateTime, 1000);// и каждую секунду