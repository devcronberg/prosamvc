# brug pip install requests 
import requests
import json
response = requests.get("https://dawa.aws.dk/kommuner/")
lst = response.json()
for x in lst:
    print(x['navn'])