cd yowsup-master
py setup.py build
py setup.py install
py yowsup-cli registration --requestcode sms --phone 201200652813 --cc 20 --mcc 602 --mnc 01
