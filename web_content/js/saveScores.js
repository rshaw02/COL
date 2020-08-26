const fs = require('fs');
let file = '../etc/userScores.json';

const user_score = (name, scores) => {
    return {
        "name": name,
        "scores": scores
    }
}

const readFile = () => {
    let newUser = fs.readFileSync(file, "utf-8");
    return JSON.parse(newUser);
}

const writeFile = data => {
    fs.writeFile(file, JSON.stringify(data), "utf-8", err => {
        if(err) throw err;
    })
}

const saveScores = (req, res) => {

    let uName = document.getElementById("txt-username").value;
    let uScore = $("ui_score");

    let newUser = readFile();
    newUser.Scores[newUser.Scores.length] = user_score(uName, uScore);

    writeFile(newUser);
    res.status(200).json(newUser);
}

document.getElementById("game-end-scoreboard-save").addEventListener("click", e => {
    e.preventDefault();
    saveScores();
})
