Public Class frmMain
    Private Function ResidentialCustomer() As Double
        Dim dblPro_fee As Double = 4.5
        Dim dblBasic_service As Double = 30
        Dim dblPre_channel As Double
        Dim dblTotalDue As Double


        Double.TryParse(lstPremium.SelectedItem.ToString, dblPre_channel)

        dblTotalDue = dblPro_fee + dblBasic_service + dblPre_channel * 5
        Return dblTotalDue
    End Function



    'function to calculate the total amount due for business customer
    Private Function BusinessCustomer() As Double
        Dim dblPro_fee As Double = 16.5
        Dim dblBasic_service As Double
        Dim dblPre_channel As Double
        Dim dblTotalDue As Double
        Dim dblConn As Double

        Double.TryParse(lstConnection.SelectedItem.ToString, dblConn)
        Double.TryParse(lstPremium.SelectedItem.ToString, dblPre_channel)

        dblPre_channel = 50

        If dblConn <= 10 And dblConn <> 0 Then
            dblBasic_service = 80
        ElseIf dblConn > 10 Then
            dblBasic_service = 80 + (dblConn - 10) * 4
        End If


        dblTotalDue = dblPro_fee + dblBasic_service + dblPre_channel


        Return dblTotalDue 'return totalDue for business customer
    End Function

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Fill list box with numbers 0-20
        For intNum As Integer = 0 To 20
            lstPremium.Items.Add(intNum)
        Next intNum
        lstPremium.SelectedIndex = 0


        'Fill connections list box with numbers (0-100)
        For intConnect As Integer = 0 To 100
            lstConnection.Items.Add(intConnect)
        Next intConnect
        lstConnection.SelectedIndex = 0
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'Variables
        Dim dblBusinessCustTtlDue As Double
        Dim dblResidentialCustTtlDue As Double


        If radBusiness.Checked Then
            dblBusinessCustTtlDue = BusinessCustomer()
            lblTtlDue.Text = dblBusinessCustTtlDue.ToString("C2")
        ElseIf radResidential.Checked Then
            dblResidentialCustTtlDue = ResidentialCustomer()
            lblTtlDue.Text = dblResidentialCustTtlDue.ToString("C2")
        End If


    End Sub
End Class
