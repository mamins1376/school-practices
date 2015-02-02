#!/usr/bin/python
import sys
from PyQt4 import QtCore, QtGui

class p130_13:
  
  def InitializeComponents(self):
    self.appApplication = QtGui.QApplication(sys.argv)
    self.wgtMain = QtGui.QWidget()
    self.grdMain = QtGui.QGridLayout()
    self.txtNumA = QtGui.QLineEdit()
    self.txtNumB = QtGui.QLineEdit()
    self.lblSum = QtGui.QLabel('Enter')
    self.lblDif = QtGui.QLabel('Your')
    self.lblMul = QtGui.QLabel('Numbers')
    
    self.txtNumA.setAlignment(QtCore.Qt.AlignCenter)
    self.txtNumA.textChanged.connect(self.Text_Changed)
    self.grdMain.addWidget(self.txtNumA, 1, 0)
    
    self.txtNumB.setAlignment(QtCore.Qt.AlignCenter)
    self.txtNumB.textChanged.connect(self.Text_Changed)
    self.grdMain.addWidget(self.txtNumB, 2, 0)
    
    self.lblSum.setAlignment(QtCore.Qt.AlignCenter)
    self.grdMain.addWidget(self.lblSum, 3, 0)
    
    self.lblDif.setAlignment(QtCore.Qt.AlignCenter)
    self.grdMain.addWidget(self.lblDif, 4, 0)
    
    self.lblMul.setAlignment(QtCore.Qt.AlignCenter)
    self.grdMain.addWidget(self.lblMul, 5, 0)
    
    self.wgtMain.setWindowTitle(' ')
    self.grdMain.setSpacing(10)
    self.wgtMain.setLayout(self.grdMain)
    self.wgtMain.setFixedSize(160, 180)

  def Text_Changed(self):
    try:
      NumA = float(str(self.txtNumA.text()))
      NumB = float(str(self.txtNumB.text()))
    except:
      self.lblSum.setText('Enter')
      self.lblDif.setText('True')
      self.lblMul.setText('Numbers!')
      return
    self.lblSum.setText('+: ' + str( NumA + NumB ))
    self.lblDif.setText('-: ' + str( NumA - NumB ))
    self.lblMul.setText('*: ' + str( NumA * NumB ))
  def __init__(self):
    self.InitializeComponents()
  
  def Run(self):
    self.wgtMain.show()
    self.appApplication.exec_()

if __name__ == '__main__' :
  myprj = p130_13()
  myprj.Run()
