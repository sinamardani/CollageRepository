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

//-------


const txtProvinceName = document.getElementById("txtProvinceName");
const txtProvinceId = document.getElementById("txtProvinceId");
const btnProvinceSubmit = document.getElementById("btnProvinceSubmit");

btnProvinceSubmit.addEventListener("click", () => {
    if (txtProvinceName.value == "" && txtProvinceName.value.length == 0) {
        toastManager("خطا", "نمی توانید فیلد استان را خالی بگزارید", "error")
        return;
    }
    fetch("ProvinceInsert", {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json;charset=utf-8'
        },
        body: JSON.stringify({
            provinceName: txtProvinceName.value
        })
    }).then(response => {
        if (response.ok) {
            toastManager();
        }
    }).catch(error => console.log(error))
});










const txtCityName = document.getElementById("txtCityName")
const txtProvinceIdForCity = document.getElementById("txtProvinceIdForCity")

document.getElementById("btnCitySubmit").addEventListener("click", () => {
    debugger;
    if (txtCityName.value == "" && txtCityName.value.length == 0) {
        toastManager("خطا", "نمی توانید فیلد شهر را خالی بگزارید", "error")
        return;
    }
    if (txtProvinceIdForCity == 0 && txtProvinceIdForCity.length == 0) {
        toastManager("خطا", "باید حتما استان مورد نظر خود را انتخاب کنید", "error")
        return;
    }
    fetch("CityInsert", {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json;charset=utf-8'
        },
        body: JSON.stringify({
            provinceId: txtProvinceIdForCity.innerText,
            cityName: txtCityName.value,
        })
    }).then(response => {
        if (response.ok) {
            toastManager();
        }
    }).catch(error => console.log(error))
});



//function gridBox_valueChanged(e) {
//    var dataGrid = document.getElementById("embedded-datagrid");
//    //var $dataGrid = $("#embedded-datagrid");

//    if (dataGrid.length) {
//        var dataGrid = dataGrid.dxDataGrid("instance");
//        dataGrid.selectRows(e.value, false);
//    }
//}

//function gridBox_displayExpr(item) {
//    provinceId = item.ID
//    return item && item.ProvinceName
//}
