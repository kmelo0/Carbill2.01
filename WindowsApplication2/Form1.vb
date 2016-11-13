'Imports for various features
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO

Public Class Form1

    ' Declares variables
    Dim CustID = TextBox_CustID
    Dim CustTitle = TextBox_NameTitle
    Dim CustName = TextBox_Name
    Dim CustAddress = TextBox_Address
    Dim CustTown = TextBox_Town
    Dim CustPhone As Integer = Val(TextBox_LandlineNum)
    Dim CustMobile As Integer = Val(TextBox_MobileNum)
    Dim CustEmail = TextBox_CustEmail
    Dim LastBillDate As Integer = Val(TextBox_LastBillDate)

    Dim CarLicense = TextBox_CarLicense
    Dim CarMake = TextBox_CarMake
    Dim CarModel = TextBox_CarModel
    Dim CarYear As Integer = Val(TextBox_CarYear)
    Dim CarEngine = TextBox_CarEngine
    Dim CarMileage = TextBox_CarMileage

    Dim CostOfRepair As Integer = Val(TextBox_CostOfRepair)
    Dim HoursTaken As Integer = Val(TextBox_HoursTaken)
    Dim VATPercent As Integer = Val(TextBox_VatType)
    Dim VATBefore As Integer = Val(TextBox_BeforeVAT)
    Dim VatAfter As Integer = Val(TextBox_AfterVAT)

    Dim notes = TextBox_Notes
    Dim TOR1 = TextBox_TOR1
    Dim TOR2 = TextBox_TOR2
    Dim TOR3 = TextBox_TOR3
    Dim TOR4 = TextBox_TOR4
    Dim TOR5 = TextBox_TOR5






    Public Sub Main()
        'All code goes here

    End Sub

    Public Sub NewCustEntry()

    End Sub

    Private Sub LoadButton()

    End Sub


    Private Sub SaveCustData()

    End Sub


    Private Sub BillCalculate()

    End Sub

    Public Sub SaveToExcel()
        'Declares excel applications 
        Dim excelApp As New Excel.Application
        Dim excelWB As Excel.Workbook
        Dim excelWS As Excel.Worksheet

        Dim CountTest As Integer
        Dim Nothinga = ""


        MessageBox.Show("testing")
        excelApp = CreateObject("Excel.Application")
        excelApp.Visible = False

        excelWB = excelApp.Workbooks.Open("C:\fuckingtestingpeiceofshit.xlsx")
        excelWS = excelWB.Sheets("Sheet1")


        Dim CurrentCell = excelWS.Range("A" & CountTest)
        If excelWS.IsEmpty(CurrentCell) = False Then
            CountTest = CountTest + 1
        Else
            excelWS.value.Range("A1") = CustTitle
        End If

        ' excelWS.Range("A" + CountTest).Value = "23ass2"


        excelWB.Save() 'As(Filename:="C:\aaaaa.xlsx", FileFormat:=51)


        excelApp.Workbooks.Close()
        excelApp.Quit()




    End Sub



    Private Sub testbutton_Click(sender As Object, e As EventArgs) Handles testbutton.Click
        SaveToExcel()
        Dim SimpleArray(25) As String
        SimpleArray(0) = CustID
        SimpleArray(1) = CustTitle
        SimpleArray(2) = CustName
        SimpleArray(3) = CustName
        SimpleArray(4) = CustTown
        SimpleArray(5) = CustPhone
        SimpleArray(6) = CustMobile
        SimpleArray(7) = CustEmail
        SimpleArray(8) = LastBillDate
        SimpleArray(9) = CarLicense
        SimpleArray(10) = CarMake
        SimpleArray(11) = CarModel
        SimpleArray(12) = CarYear
        SimpleArray(13) = CarEngine
        SimpleArray(14) = CarMileage
        SimpleArray(15) = CostOfRepair
        SimpleArray(16) = HoursTaken
        SimpleArray(17) = VATPercent
        SimpleArray(18) = VATBefore
        SimpleArray(19) = VatAfter
        SimpleArray(20) = notes
        SimpleArray(21) = TOR1
        SimpleArray(22) = TOR2
        SimpleArray(23) = TOR3
        SimpleArray(24) = TOR4
        SimpleArray(25) = TOR5


    End Sub
End Class
