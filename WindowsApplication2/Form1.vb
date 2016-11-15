Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO

Public Class Form1

    ' Declares variables

    ' Dim CustID As Integer = Val(TextBox_CustID)


    Dim excelApp As New Excel.Application
    Dim excelWB As Excel.Workbook
    Dim excelWS As Excel.Worksheet

    Public Sub ExcelArray()


    End Sub



    Public Sub Main()
        'All code goes here

    End Sub

    Private Sub NewCustEntry()

        Dim CustTitle = TextBox_NameTitle.Text.ToString
        Dim CustName = TextBox_Name.Text.ToString
        Dim CustAddress = TextBox_Address.Text.ToString
        Dim CustTown = TextBox_Town.Text.ToString
        Dim CustPhone As Integer = Val(TextBox_LandlineNum.Text)
        Dim CustMobile As Integer = Val(TextBox_MobileNum.Text)
        Dim CustEmail = TextBox_CustEmail.Text.ToString
        Dim LastBillDate As Integer = Val(TextBox_LastBillDate.Text)

        Dim CarLicense = TextBox_CarLicense.Text.ToString
        Dim CarMake = TextBox_CarMake.Text.ToString
        Dim CarModel = TextBox_CarModel.Text.ToString
        Dim CarYear As Integer = Val(TextBox_CarYear.Text)
        Dim CarEngine = TextBox_CarEngine.Text.ToString
        Dim CarMileage = TextBox_CarMileage.Text.ToString

        Dim CostOfRepair As Integer = Val(TextBox_CostOfRepair.Text)
        Dim HoursTaken As Integer = Val(TextBox_HoursTaken.Text)
        Dim VATPercent As Integer = Val(TextBox_VatType.Text)
        Dim VATBefore As Integer = Val(TextBox_BeforeVAT.Text)
        Dim VatAfter As Integer = Val(TextBox_AfterVAT.Text)

        Dim notes = TextBox_Notes.Text.ToString
        Dim TOR1 = TextBox_TOR1.Text.ToString
        Dim TOR2 = TextBox_TOR2.Text.ToString
        Dim TOR3 = TextBox_TOR3.Text.ToString
        Dim TOR4 = TextBox_TOR4.Text.ToString
        Dim TOR5 = TextBox_TOR5.Text.ToString

        Dim SimpleArray(0, 25) As String
        Dim CustID As String = TextBox_CustID.Text.ToString
        Dim i As Integer
        Dim j As Integer

        SimpleArray(0, 0) = CustID
        SimpleArray(0, 1) = CustTitle
        SimpleArray(0, 2) = CustName
        SimpleArray(0, 3) = CustName
        SimpleArray(0, 4) = CustTown
        SimpleArray(0, 5) = CustPhone
        SimpleArray(0, 6) = CustMobile
        SimpleArray(0, 7) = CustEmail
        SimpleArray(0, 8) = LastBillDate
        SimpleArray(0, 9) = CarLicense
        SimpleArray(0, 10) = CarMake
        SimpleArray(0, 11) = CarYear
        SimpleArray(0, 12) = CarEngine
        SimpleArray(0, 13) = CarMileage
        SimpleArray(0, 14) = CostOfRepair
        SimpleArray(0, 15) = HoursTaken
        SimpleArray(0, 16) = VATPercent
        SimpleArray(0, 17) = VATBefore
        SimpleArray(0, 18) = VatAfter
        SimpleArray(0, 19) = notes
        SimpleArray(0, 20) = TOR1
        SimpleArray(0, 21) = TOR2
        SimpleArray(0, 22) = TOR3
        SimpleArray(0, 23) = TOR4
        SimpleArray(0, 24) = TOR5


        excelApp = CreateObject("Excel.Application")
        excelApp.Visible = False
        excelWB = excelApp.Workbooks.Add()

        For j = 0 To 24
            For i = 0 To 1
                SimpleArray(i, j) = excelWS.Cells(i, j).value
            Next i
        Next j



        excelWB.SaveAs(Filename:="C:\Program1\" & CustID & ".xlsx", FileFormat:=51)



    End Sub

    Private Sub LoadButton()

    End Sub


    Private Sub SaveCustData()

    End Sub


    Private Sub BillCalculate()

    End Sub

    Public Sub SaveToExcel()


    End Sub



    Private Sub testbutton_Click(sender As Object, e As EventArgs) Handles testbutton.Click

        NewCustEntry()



    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub
End Class
