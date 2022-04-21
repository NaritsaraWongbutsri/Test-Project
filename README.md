# Test-Project
ความเป็นมาของโปรแกรม
```
โปรแกรมที่สร้างขึ้นนี้เป็นโปรแกรมแปลงค่าสกุลเงินของ10ประเทศในอาเซียน สร้างขึ้นมาเพื่อแก้ปัญหาสำหรับคนที่ต้องการรู้ค่าของสกุลเงินแต่ละประเทศที่ใช้เงินไทยแลกเปลี่ยนมา 
ช่วยตอบปัญหาก่อนไปเที่ยวต่างประเทศของเราด้วยการแลกเปลี่ยนและแปลงค่าสกุลเงิน
```
วัตถุประสงค์ของโปรแกรม
```
1.เพื่อช่วยในการแปลงค่าสกุลเงินแต่ละประเทศที่เราอยากรู้ในอาเซียน และจะได้สะดวกสะบายและรู้ค่าของสกุลเงินแต่ละประเทศด้วย
2.เพื่อที่จะได้ตอบปัญหาก่อนคิดจะไปเที่ยวในประเทศต่างๆ
```
Class Diagram
```mermaid
classDiagram
  direction LR
  class Form1{
  +OK()void
  +Cancel()void
  }
  class Form2{
  +Currency()void
  +SaveFile()void
  }
  class CurrencyConverter{
  -brunei:double
  -cambodia:double
  -indonesia:double
  -laos:double
  -malaysia:double
  -myanmar:double
  -philippines:double
  -singapore:double
  -vietnam:double
  +addBrunei(double bath)void
  +getBrunei()double
  +addCambodia(double bath)void
  +getCombodia()double
  +addIndonesia(double bath)void
  +getIndonesia()double
  +addLaos(double bath)void
  +getLaos()double
  +addMalaysia(double bath)void
  +getMalaysia()double
  +addMyanmar(double bath)void
  +getMyanmar()double
  +addPhilippines(double bath)void
  +getPhilippines()double
  +addSingapore(double bath)void
  +getSingapore()double
  +addVietnam(double bath)void
  +getVietnam()double
  }
  Form2 -- CurrencyConverter
```
ผู้พัฒนาโปรแกรม
```
นางสาวนริศรา วงค์บุตรศรี รหัสนักศึกษา 643450328-8
```
