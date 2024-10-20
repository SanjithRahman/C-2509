function calculateTotal() {
    const billAmount = parseFloat(document.getElementById('bill').value);
    const tipPercentage = parseFloat(document.getElementById('tip').value);
    const tipAmount = billAmount * (tipPercentage / 100);
    const totalAmount = billAmount + tipAmount;

    document.getElementById('total').innerText = 'Total Amount: $' + totalAmount.toFixed(2);
}
