from flask import Flask, render_template, request

app = Flask(__name__)

@app.route("/")
def index():
	return render_template("index.html")

@app.route("/hey", methods=["POST"])
def hey():
	name = request.form.get("name")
	return render_template("hey.html", name=name) 