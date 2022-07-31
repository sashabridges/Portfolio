const fs = require('fs')
const chalk = require('chalk')

const addNote = (title, body) => {
    const notes = loadNotes()

    // const duplicateNotes = notes.filter((note) => note.title === title )

    // if (duplicateNotes.length === 0) {
    //     notes.push({
    //         title: title,
    //         body: body
    //     })
    //     saveNotes(notes)
    //     console.log(chalk.green.inverse.bold('Note added!'))
    // } else {
    //     console.log(chalk.red.inverse.bold('Note title taken!'))
    // }

    const duplicateNote = notes.find((note) => note.tile === title)
    if (!duplicateNote) {
       notes.push({
           title: title,
           body: body
       })
         saveNotes(notes)
         console.log(chalk.green.inverse.bold('Note added!'))
    } else { 
        console.log(chalk.red.inverse.bold('Note title taken!')) 
    }
}

const removeNote = (title) => {
    const notes = loadNotes()
    const nonmatching = notes.filter((note) => note.title != title)
    
    saveNotes(nonmatching)
    
    if (notes.length > nonmatching.length) {
        console.log(chalk.green.inverse.bold('Note removed!'))
    } else {
        console.log(chalk.red.inverse.bold('No note found!'))
    }
}

const readNote = (title) => {
    const notes = loadNotes()
    const match = notes.find((note) => note.title === title)

    if (match) {
        console.log(chalk.inverse(match.title))
        console.log(match.body)
    } else {
        console.log(chalk.red.inverse('Note not found!'))
    }
}

const listNotes = () => {
    const notes = loadNotes()
    console.log(chalk.inverse('Your Notes'))

    notes.forEach(() => {
        console.log(note.title)
    })
}

const saveNotes =  (notes) => {
    const dataJSON = JSON.stringify(notes)
    fs.writeFileSync('notes.json', dataJSON)
}

const loadNotes = () =>  {
    try {
        const dataBuffer = fs.readFileSync('notes.json')
        const dataJSON = dataBuffer.toString()
        return JSON.parse(dataJSON)
    } catch (e) {
        return []
    }
}

module.export = {
    addNote: addNote,
    removeNote: removeNote,
    listNotes: listNotes,
    readNote: readNote
}
