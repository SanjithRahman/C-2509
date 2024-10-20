let seconds = 0;
let   intervalId;

function updateTime() {
    seconds++;
    document.getElementById('time').innerText = seconds; 
}

document.getElementById('startBtn').onclick = function() {
    if (!intervalId) {
        intervalId = setInterval(updateTime, 1000);
    }
}

document.getElementById('stopBtn').onclick = function() {
    clearInterval( intervalId);
    intervalId = 0;
}

document.getElementById('resetBtn').onclick = function() {
    clearInterval(intervalId);
    intervalId = 0;
    seconds = 0;
    document.getElementById('time').innerText = '0'; 
}