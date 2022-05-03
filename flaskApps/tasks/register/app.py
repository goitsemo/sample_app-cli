import sqlite3
from flask_sqlalchemy import SQLAlchemy
from flask import Flask, render_template

app = Flask(__name__)

db = sqlite3.connect("lecture.db")

@app.route("/")
def index():
    rows = db.execute("SELECT * FROM students")
    return render_template("index.html", rows=rows)