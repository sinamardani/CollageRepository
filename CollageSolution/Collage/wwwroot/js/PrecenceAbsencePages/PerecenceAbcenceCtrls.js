const studentContainer = document.getElementsByClassName("student-value");
for (var i = 0; i < studentContainer.length; i++) {
    studentContainer[i].childNodes[1].childNodes[1].setAttribute("id", `status${i + 1}`)
    studentContainer[i].childNodes[1].childNodes[1].childNodes[5].childNodes[3]
        .childNodes[1].childNodes[1].setAttribute("id", `btnPrecence${i + 1}`)
    studentContainer[i].childNodes[1].childNodes[1].childNodes[3].childNodes[5].childNodes[1].setAttribute("id", `studentId${i + 1}`)
    studentContainer[i].childNodes[1].childNodes[1].childNodes[5].childNodes[3].childNodes[3].childNodes[1].setAttribute("id", `btnPrecenceAbsence${i + 1}`)
}

const sendDataToServer = function (url, studentId, precenceOrAbcenceStatus) {
    fetch(`${url}`, {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json;charset=utf-8'
        },
        body: JSON.stringify({
            studentId: studentId,
            precenceOrAbcenceStatus: precenceOrAbcenceStatus
        })
    }).then(response => {
        if (response.ok) {

        }
    }).catch(error => console.log(error))
}

document.body.addEventListener('click', (event) => {
    switch (event.target.id) {
        case "btnPrecence1":
            const studentId = document.getElementById("studentId1").value;
            document.getElementById("status1").classList.remove("bg-secondary")
            document.getElementById("status1").style.backgroundColor = "#00BFA5";
            sendDataToServer("CheckStudent", studentId, 1)
            break;
        case "btnPrecenceAbsence1":
            const studentIdA1 = document.getElementById("studentId1").value;
            document.getElementById("status1").classList.remove("bg-secondary")
            document.getElementById("status1").style.backgroundColor = "#dd6f6f";
            sendDataToServer("CheckStudent", studentIdA1, 0)
            break;


        case "btnPrecence2":
            const studentId2 = document.getElementById("studentId2").value;
            document.getElementById("status2").classList.remove("bg-secondary")
            document.getElementById("status2").style.backgroundColor = "#00BFA5";
            sendDataToServer("CheckStudent", studentId2, 1)
            break;
        case "btnPrecenceAbsence2":
            const studentIdA2 = document.getElementById("studentId2").value;
            document.getElementById("status2").classList.remove("bg-secondary")
            document.getElementById("status2").style.backgroundColor = "#dd6f6f";
            sendDataToServer("CheckStudent", studentIdA2, 0)
            break;


        case "btnPrecence3":
            const studentId3 = document.getElementById("studentId3").value;
            document.getElementById("status3").classList.remove("bg-secondary")
            document.getElementById("status3").style.backgroundColor = "#00BFA5";
            sendDataToServer("CheckStudent", studentId3, 1)
            break;
        case "btnPrecenceAbsence3":
            const studentIdA3 = document.getElementById("studentId3").value;
            document.getElementById("status3").classList.remove("bg-secondary")
            document.getElementById("status3").style.backgroundColor = "#dd6f6f";
            sendDataToServer("CheckStudent", studentIdA3, 0)
            break;


        case "btnPrecence4":
            const studentId4 = document.getElementById("studentId4").value;
            document.getElementById("status4").classList.remove("bg-secondary")
            document.getElementById("status4").style.backgroundColor = "#00BFA5";
            sendDataToServer("CheckStudent", studentId4, 1)
            break;
        case "btnPrecenceAbsence4":
            const studentIdA4 = document.getElementById("studentId4").value;
            document.getElementById("status4").classList.remove("bg-secondary")
            document.getElementById("status4").style.backgroundColor = "#dd6f6f";
            sendDataToServer("CheckStudent", studentIdA4, 0)
            break;


        case "btnPrecence5":
            const studentId5 = document.getElementById("studentId5").value;
            document.getElementById("status5").classList.remove("bg-secondary")
            document.getElementById("status5").style.backgroundColor = "#00BFA5";
            sendDataToServer("CheckStudent", studentId5, 1)
            break;
        case "btnPrecenceAbsence5":
            const studentIdA5 = document.getElementById("studentId5").value;
            document.getElementById("status5").classList.remove("bg-secondary")
            document.getElementById("status5").style.backgroundColor = "#dd6f6f";
            sendDataToServer("CheckStudent", studentIdA5, 0)
            break;


        case "btnPrecence6":
            const studentId6 = document.getElementById("studentId6").value;
            document.getElementById("status6").classList.remove("bg-secondary")
            document.getElementById("status6").style.backgroundColor = "#00BFA5";
            sendDataToServer("CheckStudent", studentId6, 1)
            break;
        case "btnPrecenceAbsence6":
            const studentIdA6 = document.getElementById("studentId6").value;
            document.getElementById("status6").classList.remove("bg-secondary")
            document.getElementById("status6").style.backgroundColor = "#dd6f6f";
            sendDataToServer("CheckStudent", studentIdA6, 0)
            break;


        case "btnPrecence7":
            const studentId7 = document.getElementById("studentId7").value;
            document.getElementById("status7").classList.remove("bg-secondary")
            document.getElementById("status7").style.backgroundColor = "#00BFA5";
            sendDataToServer("CheckStudent", studentId7, 1)
            break;
        case "btnPrecenceAbsence7":
            const studentIdA7 = document.getElementById("studentId7").value;
            document.getElementById("status7").classList.remove("bg-secondary")
            document.getElementById("status7").style.backgroundColor = "#dd6f6f";
            sendDataToServer("CheckStudent", studentIdA7, 0)
            break;


        case "btnPrecence8":
            const studentId8 = document.getElementById("studentId8").value;
            document.getElementById("status8").classList.remove("bg-secondary")
            document.getElementById("status8").style.backgroundColor = "#00BFA5";
            sendDataToServer("CheckStudent", studentId8, 1)
            break;
        case "btnPrecenceAbsence8":
            const studentIdA8 = document.getElementById("studentId8").value;
            document.getElementById("status8").classList.remove("bg-secondary")
            document.getElementById("status8").style.backgroundColor = "#dd6f6f";
            sendDataToServer("CheckStudent", studentIdA8, 0)
            break;


        case "btnPrecence9":
            const studentId9 = document.getElementById("studentId9").value;
            document.getElementById("status9").classList.remove("bg-secondary")
            document.getElementById("status9").style.backgroundColor = "#00BFA5";
            sendDataToServer("CheckStudent", studentId9, 1)
            break;
        case "btnPrecenceAbsence9":
            const studentIdA9 = document.getElementById("studentId9").value;
            document.getElementById("status9").classList.remove("bg-secondary")
            document.getElementById("status9").style.backgroundColor = "#dd6f6f";
            sendDataToServer("CheckStudent", studentIdA9, 0)
            break;

        case "btnPrecence10":
            const studentId10 = document.getElementById("studentId10").value;
            document.getElementById("status10").classList.remove("bg-secondary")
            document.getElementById("status10").style.backgroundColor = "#00BFA5";
            sendDataToServer("CheckStudent", studentId10, 1)
            break;
        case "btnPrecenceAbsence10":
            const studentIdA10 = document.getElementById("studentId10").value;
            document.getElementById("status10").classList.remove("bg-secondary")
            document.getElementById("status10").style.backgroundColor = "#dd6f6f";
            sendDataToServer("CheckStudent", studentIdA10, 0)
            break;
    }
});