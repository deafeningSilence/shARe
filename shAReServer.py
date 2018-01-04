from flask import Flask, jsonify, request
from nltk.tokenize import word_tokenize
import os

app = Flask(__name__)

@app.route('/')
def index():
    return "hello world"

@app.route('/addToCart', methods = ["POST"])
def addToCart():
    req_json = request.json
    table_id = req_json['TABLE_ID']
    dish_name = req_json["DISH_NAME"]
    price = req_json["PRICE"]

    print("table "+str(table_id)+" has ordered a "+dish_name+" at Rs."+ str(price))
    f = open("table"+str(table_id)+'.txt','a')
    f.write('\n' + dish_name+ " "+str(price))
    f.close()
    return "hello world"

@app.route('/getCart')
def getCart():
    return "cart"

if __name__ == '__main__':
	app.run(debug=True, host='0.0.0.0', port=int("8080"))
