document.addEventListener("DOMContentLoaded", function () {
  // Tarih seçici için kodlar
  const checkinInput = document.getElementById("checkin");
  const checkoutInput = document.getElementById("checkout");

  // Bugünün tarihini al
  const today = new Date().toISOString().split("T")[0];

  // Başlangıçta minimum tarihleri ayarla
  checkinInput.min = today;
  checkoutInput.min = today;

  // Check-in değiştiğinde
  checkinInput.addEventListener("change", function () {
    const checkinDate = new Date(this.value);
    const checkoutDate = new Date(checkoutInput.value);

    // Check-out'un minimum tarihini check-in'den bir gün sonrasına ayarla
    const minCheckoutDate = new Date(checkinDate);
    minCheckoutDate.setDate(minCheckoutDate.getDate() + 1);
    checkoutInput.min = minCheckoutDate.toISOString().split("T")[0];

    // Eğer check-out tarihi, check-in tarihinden önceyse veya aynıysa
    if (!checkoutInput.value || checkoutDate <= checkinDate) {
      checkoutInput.value = minCheckoutDate.toISOString().split("T")[0];
    }
  });

  // Check-out seçildiğinde
  checkoutInput.addEventListener("change", function () {
    const checkinDate = new Date(checkinInput.value);
    const checkoutDate = new Date(this.value);

    // Eğer check-out tarihi check-in tarihinden önceyse
    if (checkoutDate <= checkinDate) {
      const newCheckoutDate = new Date(checkinDate);
      newCheckoutDate.setDate(newCheckoutDate.getDate() + 1);
      this.value = newCheckoutDate.toISOString().split("T")[0];
    }
  });

  // Başlangıçta check-in seçilmemişse check-out'u devre dışı bırak
  if (!checkinInput.value) {
    checkoutInput.disabled = true;
  }

  // Check-in seçildiğinde check-out'u aktif et
  checkinInput.addEventListener("input", function () {
    checkoutInput.disabled = !this.value;
  });
});
