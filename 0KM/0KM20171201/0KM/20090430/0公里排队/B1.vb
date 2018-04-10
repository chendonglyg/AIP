Public Class B1
    Dim vehicle, stre_2, stre_3, phone_no As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '车辆申报
        If Color.Checked = True Then

            vehicle = Trim(chehao.Text) & "蓝"
        Else

            vehicle = Trim(chehao.Text)
        End If





        Dim insertsomething As New lygport_outside.Service1SoapClient


        phone_no = Trim(dianhuahaoma.Text)

        stre_2 = insertsomething.InsertConsignVehicle("siewn%%iu#$W*insert_yh", vehicle, phone_no)

        MessageBox.Show(stre_2, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)


        '注意:
        '(1)对于传入的参数vehicle，phone_no,均不能为空
        '(2)当strE返回的是success表明申报成功
        '        未申报成功原因请参照strE返回值的内容()
        '车辆放行

        Dim updatesomething As New lygport_outside.Service1SoapClient
        stre_3 = updatesomething.UpdateConsignVehicle("ygygdn%hjiu**W*update_yh", vehicle)

        MessageBox.Show(stre_3, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)

        '-------------------------------------------------------------------------------------------------

     


    End Sub

    Private Sub Color_CheckedChanged(sender As Object, e As EventArgs) Handles Color.CheckedChanged
        If Color.Checked = True Then
            chehao.BackColor = Drawing.Color.Blue
        Else
            chehao.BackColor = Drawing.Color.Yellow

        End If
    End Sub

    Private Sub B1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class