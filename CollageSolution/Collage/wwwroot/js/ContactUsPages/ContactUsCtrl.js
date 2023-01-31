function toastManager(title = "موفقیت", message = "عملیات با موفقیت انجام شد", typeOfMessage = "success") {
    let bgColor;
    if (typeOfMessage == "success") {
        bgColor = "bg-success"
        textColor = "text-white"
    }
    if (typeOfMessage == "error") {
        bgColor = "bg-danger"
        textColor = "text-white"
    }
    if (typeOfMessage == "warning") {
        bgColor = "bg-warning"
        textColor = "text-dark"
    }
    setTimeout(() => {
        const liveToast = document.getElementById("liveToast");
        liveToast.classList.remove("show");
        liveToast.classList.add("hide");
    }, 3000)
    document.getElementById("toast").innerHTML = ` <div id="liveToast" class="toast show ${bgColor}" role="alert"  aria-live="assertive" aria-atomic="true">
        <div class="toast-header ${bgColor} justify-content-between">
            <strong class="me-auto vazir-font-medium ${textColor}">${title}</strong>
            <div id="closeTheToast"  onclick="closedToast()" style="font-size:32px;cursor:pointer" class="text-left ${textColor}">&times;</div>
        </div>
        <div class="vazir-font-regular ${textColor}" style="font-weight:100;font-size:20px">
           ${message}
        </div>
    </div>`
}
closedToast = function () {
    const liveToast = document.getElementById("liveToast");
    liveToast.classList.remove("show");
    liveToast.classList.add("hide");
}


//*************************

const validationEmail = /[a-zA-Z0-9._]{3,25}@[a-z]{4,7}.[a-z]{2,3}/g;


const name = document.getElementById("name");
const email = document.getElementById("email");
const subject = document.getElementById("subject");
const message = document.getElementById("message");

debugger;

document.getElementById("email").addEventListener("change", () => {
    if (!validationEmail.test(email.value)) {
        toastManager("خطا", `لطفا یک ایمیل معتبر استفاده کنید`, "error")
        return;
    }
})



document.getElementById("sendMessag").addEventListener("click", () => {
    if (name.value == "" || name.length == 0) {
        toastManager("خطا", "نمی توانید نام خود را خالی بگزارید", "warning")
        return;
    }
    if (email.value == "" || email.length == 0) {
        toastManager("خطا", "نمی توانید ایمل خود را خالی بگزارید", "warning")
        return;
    }
    if (subject.value == "" || subject.length == 0) {
        toastManager("خطا", "نمی توانید عنوان ایمیل خود را خالی بگزارید", "warning")
        return;
    }
    if (message.value == "" || message.length == 0) {
        toastManager("خطا", "نمی توانید پیغام خود را خالی بگزارید", "warning")
        return;
    }
    if (validationEmail.test(email.value)) {
        toastManager("خطا", `لطفا یک ایمیل معتبر استفاده کنید`, "error")
        return;
    }

    else {
        fetch("Submit", {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json;charset=utf-8'
            },
            body: JSON.stringify({
                name: name.value,
                email: email.value,
                subject: subject.value,
                message: message.value
            })
        }).then(response => {
            if (response.ok) {
                toastManager("ثبت", `عملیات با موفقیت انجام شد`, "success")
                name.value = email.value = subject.value = message.value = ""
            }
        }).catch(error => console.log(error))
    }
});