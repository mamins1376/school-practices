#!/usr/bin/python
import sys
from PyQt4 import QtCore, QtGui


class p130_13:

  def InitializeComponents(self):
    self.appApplication = QtGui.QApplication(sys.argv)
    self.wgtMain = QtGui.QWidget()
    self.grdMain = QtGui.QGridLayout()
    self.txtInput = QtGui.QLineEdit()
    self.lblResult = QtGui.QLabel('Enter something...')

    self.txtInput.setAlignment(QtCore.Qt.AlignCenter)
    self.txtInput.textChanged.connect(self.Text_Changed)
    self.grdMain.addWidget(self.txtInput, 1, 0)

    self.lblResult.setAlignment(QtCore.Qt.AlignCenter)
    self.grdMain.addWidget(self.lblResult, 2, 0)

    self.wgtMain.setWindowTitle('130, 9 in Python')
    self.grdMain.setSpacing(10)
    self.wgtMain.setLayout(self.grdMain)
    self.wgtMain.setFixedSize(160, 70)

  def Text_Changed(self):
    if len(str(self.txtInput.text())) == 0:
      self.lblResult.setText('Enter something...')
      return
    self.lblResult.setText(str(self.txtInput.text())[::-1])

  def __init__(self):
    self.InitializeComponents()

  def Run(self):
    self.wgtMain.show()
    self.appApplication.exec_()

if __name__ == '__main__':
  myprj = p130_13()
  myprj.Run()
