const students = [
  {
    name: "Mycola",
    lastname: "Shepel",
    birthYear: 2005,
    marks: [
      {
        name: "ОІР",
        mark: 4
      },
      {
        name: "ІЗВП",
        mark: 4
      }
    ]
  },
  {
    name: "Dima",
    lastname: "Yenich",
    birthYear: 2004,
    marks: [
      {
        name: "ПКІ",
        mark: 5
      },
      {
        name: "ІЗВП",
        mark: 5
      }
    ]
  },
  {
    name: "Dima",
    lastname: "Segen",
    birthYear: 2005,
    marks: [
      {
        name: "ОІР",
        mark: 5
      },
      {
        name: "Логіка в інформатиці",
        mark: 4
      }
    ]
  }
];


function printStudentInfo(studentsList) {
  studentsList.forEach(function (studentInfo) {
    Logger.log("1---------------------------------");
    Logger.log("Name: " +  studentInfo.name);
    Logger.log("Lastname: " +  studentInfo.lastname);
    Logger.log("Birth year: " +  studentInfo.birthYear);
    var summa = 0;
    studentInfo.marks.forEach(function (subjectInfo) {
        summa = summa + subjectInfo.mark;
    });
    Logger.log("Summa marks: " + summa);
    Logger.log("Average mark: " + summa / studentInfo.marks.length);
  });
}

function printDisciplineInfo(studentsList, discipline) {
  var studentsInfo = [];
  studentsList.forEach(function (studentInfo) {
    var disciplineMark = studentInfo.marks.find(mark => mark.name === discipline);
    if (disciplineMark) {
      studentsInfo.push({
        name: studentInfo.name,
        lastname: studentInfo.lastname,
        birthYear: studentInfo.birthYear,
        mark: disciplineMark.mark
      });
    }
  });
  studentsInfo.sort(function (a, b) {
    return b.mark - a.mark;
  });
  studentsInfo.forEach(function (studentInfo) {
    Logger.log("2---------------------------------");
    Logger.log("Name: " + studentInfo.name);
    Logger.log("Lastname: " + studentInfo.lastname);
    Logger.log("Birth year: " + studentInfo.birthYear);
    Logger.log(discipline + " mark: " + studentInfo.mark);
  });
}

function minAverageMark(studentsList, n) {
  studentsList.forEach(function (studentInfo) {
    var summa = 0;
    studentInfo.marks.forEach(function (subjectInfo) {
      summa += subjectInfo.mark;
    });
    var minAverage = summa / studentInfo.marks.length;
    if (minAverage >= n) {
      Logger.log("3------------------------------");
      Logger.log("Name: " + studentInfo.name);
      Logger.log("Lastname: " + studentInfo.lastname);
      Logger.log("Birth year: " + studentInfo.birthYear);
      Logger.log("Average mark: " + minAverage);
    }
  });
}

function main(){
  printStudentInfo(students);
  printDisciplineInfo(students, "ОІР");
  minAverageMark(students, 4.5);
  
}

