import json
import requests

# Set global parameters 
authentication_needed = True
doDisplaySystemsCheck = True

# Set the URL of the JSON-RPC Web service
requesturl = 'http://169.254.103.43/webapi/JsonRPC'


# Set the Authorization Header with a Bearer Token if using Authentication
# Deze variabele wordt later gevuld met het Token uit de Barco 
headers = {"Authorization":"Bearer eyJVc2VybmFtZSI6ImFtZWphIiwiUGFzc3dvcmQiOiJwYXNzMS4iLCJNYWNoaW5lSWQiOiJBRzMzLVpKUDItV0s5Mi1HVEw0LURKTjYtS1gySi1SQ0ZaLVpETU0tVzY1Ti1SVUEiLCJUaW1lTGltaXRJbk1pbnV0ZXMiOjIwLCJJc3N1ZWREYXRlVGltZSI6IjIwMTgtMDEtMThUMDk6MDM6NTQuODYyMDc1MS0wODowMCJ9"}

# Set a global Display System ID for doing get/set requests on
displaySystemId = 0

# If authentication is needed, then try to authenticate with a username and password
if authentication_needed is True:
     request = {'jsonrpc':'2.0', 'method':'GetPublicKey', 'params':{ 'username':'ameja', 'password':'pass1.'}, 'id':1234}
     json_request = json.dumps(request)
     returnValue = requests.post(requesturl, json_request)
     json_ReturnValue = json.loads(returnValue.content)

     request = {'jsonrpc':'2.0', 'method':'Authenticate', 'params':{'EncryptedString':'UpbbVGNS08Z5xEniPoQIFfaW5c/ID1rNV3YdRyfh+ThgLDRr6U6TZ3CweQ/RxpgOnXqsXfCwSJ4HHnsBCEl+0ywyCxAVLc3NKouZFOSARwAdK4DpYwBdP/G0iW4PAJcEbubB4o0qSxLMvs499GZxWH+ra6kt4lg5vp1qZuzei9U='}, 'id':1234}
     json_request = json.dumps(request)
     returnValue = requests.post(requesturl, json_request)
     json_ReturnValue = json.loads(returnValue.content)
     if 'result' in json_ReturnValue:
          print("Authentication Token is " + str(json_ReturnValue['result']))
          print("Authentication Token is " + str(json_ReturnValue['result']['Token']))
          headers = {"Authorization":"Bearer " + str(json_ReturnValue['result']['Token'])}
     else:
          print("error is " + json_ReturnValue['error']['message'])
else:
     print('do nothing')

#GET Display System Ids
request = {'jsonrpc':'2.0', 'method':'GetDisplaySystemIds', 'params':{}, 'id':'1234'}
json_request = json.dumps(request)

returnValue = requests.post(requesturl, json_request, headers=headers)
json_ReturnValue = json.loads(returnValue.content)
if 'result' in json_ReturnValue:
     print("Display System Ids is " + str(json_ReturnValue['result']))
     displaySystemId = json_ReturnValue['result'][0]['ID']
else:
     print("error is " + json_ReturnValue['error']['message'])
           
#GET and SET active source
request = {'jsonrpc':'2.0', 'method':'GetActiveSource', 'params':{'DisplaySystemId':displaySystemId}, 'id':1234}
json_request = json.dumps(request)
returnValue = requests.post(requesturl, json_request, headers=headers)
json_ReturnValue = json.loads(returnValue.content)
if 'result' in json_ReturnValue:
     print("Active source is " + str(json_ReturnValue['result']))
else:
     print("error is " + json_ReturnValue['error']['message'])


request = {'jsonrpc':'2.0', 'method':'SetActiveSource', 'params':{'DisplaySystemId':displaySystemId, 'Source':'hdmi'}, 'id':1234}
json_request = json.dumps(request)
returnValue = requests.post(requesturl, json_request, headers=headers)
json_ReturnValue = json.loads(returnValue.content)
if 'result' in json_ReturnValue:
     print("Set active source result is " + str(json_ReturnValue['result']))
else:
     print("error is " + json_ReturnValue['error']['message'])


#GET and SET luminance
request = {'jsonrpc':'2.0', 'method':'GetLuminance', 'params':{'DisplaySystemId':displaySystemId}, 'id':1234}
json_request = json.dumps(request)
returnValue = requests.post(requesturl, json_request, headers=headers)
json_ReturnValue= json.loads(returnValue.content)
if 'result' in json_ReturnValue:
     print("Luminance is " + json_ReturnValue['result']['CurrentValue'])
else:
     print("error is " + json_ReturnValue['error']['message'])


request = {'jsonrpc':'2.0', 'method':'SetLuminance', 'params':{'DisplaySystemIds':displaySystemId, 'value':10}, 'id':1234}
json_request = json.dumps(request)
returnValue = requests.post(requesturl, json_request, headers=headers)
json_ReturnValue= json.loads(returnValue.content)
if 'result' in json_ReturnValue:
     print("Set luminance result is " + str(json_ReturnValue['result']))
else:
     print("error is " + json_ReturnValue['error']['message'])

#GET and SET color temperature
request = {'jsonrpc':'2.0', 'method':'GetColorTemperature', 'params':{'DisplaySystemId':displaySystemId}, 'id':1234}
json_request = json.dumps(request)
returnValue = requests.post(requesturl, json_request, headers=headers)
json_ReturnValue= json.loads(returnValue.content)
if 'result' in json_ReturnValue:
     print("Color Temperature is " + json_ReturnValue['result']['CurrentValue'])
else:
     print("error is " + json_ReturnValue['error']['message'])


request = {'jsonrpc':'2.0', 'method':'SetColorTemperature', 'params':{'DisplaySystemIds':displaySystemId, 'Value':4900}, 'id':1234}
json_request = json.dumps(request)
returnValue = requests.post(requesturl, json_request, headers=headers)
json_ReturnValue= json.loads(returnValue.content)
if 'result' in json_ReturnValue:
     print("Set color temperature result is " + str(json_ReturnValue['result']))
else:
     print("error is " + json_ReturnValue['error']['message'])


#GET and SET source position and output size
#request = {'jsonrpc':'2.0', 'method':'GetSourcePositionAndOutputSize', 'params':{'displaySystemId':displaySystemId, 'source':'hdmi'}, 'id':1234}
#json_request = json.dumps(request)
#returnValue= requests.post(requesturl, json_request, headers=headers)
#json_ReturnValue= json.loads(returnValue.content)
#if 'result' in json_ReturnValue:
#     print("Source position and output size is " + str(json_ReturnValue['result']))
#else:
#     print("error is " + json_ReturnValue['error']['message'])


#request = {'jsonrpc':'2.0', 'method':'setSourcePositionAndOutputSize', 'params':{'displaySystemIds':displaySystemId, 'source':'hdmi', 'x':30, 'y':40, 'width':1000, 'height':1000}, 'id':1234}
#json_request = json.dumps(request)
#returnValue= requests.post(requesturl, json_request, headers=headers)
#json_ReturnValue= json.loads(returnValue.content)
#if 'result' in json_ReturnValue:
#     print("Set source position and outputs result is " + str(json_ReturnValue['result']))
#else:
#     print("error is " + json_ReturnValue['error']['message'])

#GET and SET source settings
request = {'jsonrpc':'2.0', 'method':'GetSource', 'params':{'DisplaySystemId':displaySystemId, 'SourceType':'hdmi'}, 'id':1234}
json_request = json.dumps(request)
returnValue= requests.post(requesturl, json_request, headers=headers)
json_ReturnValue= json.loads(returnValue.content)
if 'result' in json_ReturnValue:
     brightness = [x for x in json_ReturnValue['result']['ImageProcessingParameters'] if x['Type'] == "Brightness"]
     print("brightness " + str(brightness[0]["Value"]))
     contrast = [x for x in json_ReturnValue['result']['ImageProcessingParameters'] if x['Type'] == "Contrast"]
     print("contrast " + str(contrast[0]["Value"]))
     source = json_ReturnValue['result']
else:
     print("error is " + json_ReturnValue['error']['message'])

source['ImageProcessingParameters'][0]['Value'] = 0.5
print("source " + str(source))

request = {'jsonrpc':'2.0', 'method':'SetSource', 'params':{'DisplaySystemIds':displaySystemId, 'Source': source}, 'id':1234}
json_request = json.dumps(request)
returnValue= requests.post(requesturl, json_request, headers=headers)
json_ReturnValue= json.loads(returnValue.content)
if 'result' in json_ReturnValue:
     print("Set source result is " + str(json_ReturnValue['result']))
else:
     print("error is " + json_ReturnValue['error']['message'])
     

#GET and SET Test pattern settings
request = {'jsonrpc':'2.0', 'method':'GetTestPatternSettings', 'params':{'DisplaySystemId':displaySystemId}, 'id':1234}
json_request = json.dumps(request)
returnValue= requests.post(requesturl, json_request, headers=headers)
json_ReturnValue= json.loads(returnValue.content)
print(' ')
print('Result = ' + str(json_ReturnValue))
if 'result' in json_ReturnValue:
     print("Test pattern settings are " + str(json_ReturnValue['result']))
else:
     print("error is " + json_ReturnValue['error']['message'])

request = {'jsonrpc':'2.0', 'method':'settestpatternsettings', 'params':{'displaySystemIds':displaySystemId, 'pattern':'grid_32', 'red':100, 'green':100, 'blue':100, 'movement':'true', 'direction':'diagonal'}, 'id':1234}
json_request = json.dumps(request)
returnValue = requests.post(requesturl, json_request, headers=headers)
json_ReturnValue= json.loads(returnValue.content)
if 'result' in json_ReturnValue:
     print("Set test pattern settings result is " + str(json_ReturnValue['result']))
else:
     print("error is " + json_ReturnValue['error']['message'])


#GET and SET display systems if flag is set
if doDisplaySystemsCheck is True:    
     request = {'jsonrpc':'2.0', 'method':'getDisplaySystems', 'params':{}, 'id':1234}
     json_request = json.dumps(request)
     returnValue= requests.post(requesturl, json_request, headers=headers)
     json_ReturnValue= json.loads(returnValue.content)
     if 'result' in json_ReturnValue:
          print("Display system is " + str(json_ReturnValue['result'][0]))
          displaySystem = json_ReturnValue['result'][0]
     else:
          print("error is " + json_ReturnValue['error']['message'])

     #Set a partial list of params to set for the display system
     partialDisplaySystem = {}
     partialDisplaySystem['ID'] = displaySystem['ID']
     partialDisplaySystem['ActiveSource'] = 'sdi'
     partialDisplaySystem['Luminance'] = 30
     partialDisplaySystem['ColorTemperature'] = {}
     partialDisplaySystem['ColorTemperature']['CurrentValue'] = 4900
     partialDisplaySystem['Gamma'] = {}
     partialDisplaySystem['Gamma']['CurrentValue'] = 1.5
     partialDisplaySystem['Name'] = 'Emulatortest'

     request = {'jsonrpc':'2.0', 'method':'setDisplaySystems', 'params':{'displaySystems':partialDisplaySystem}, 'id':1234}
     json_request = json.dumps(request)
     returnValue= requests.post(requesturl, json_request, headers=headers)
     json_ReturnValue= json.loads(returnValue.content)
     if 'result' in json_ReturnValue:
          print("Set Display System result is " + json_ReturnValue['result'])
     else:
          print("error is " + json_ReturnValue['error']['message'])
