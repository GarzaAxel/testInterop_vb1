Public Class Form1
    Private Sub btnGuardarWord_Click(sender As Object, e As EventArgs) Handles btnGuardarWord.Click
        Dim Word = New Microsoft.Office.Interop.Word.Application
        Dim wordApp = Word.Application()

        Dim ruta, dato As String

        If (SaveFileDialog1.ShowDialog() <> DialogResult.OK) Then
            Return
        End If

        ruta = SaveFileDialog1.FileName
        wordApp.Visible = True
        wordApp.Documents.Add()
        dato = txtDato.Text

        wordApp.Selection.TypeText(dato)
        wordApp.ActiveDocument.SaveAs2(ruta)
    End Sub

    Private Sub btnGuardarExcel_Click(sender As Object, e As EventArgs) Handles btnGuardarExcel.Click
        Dim Excel = New Microsoft.Office.Interop.Excel.Application
        Dim excelApp = Excel.Application()

        Dim ruta As String

        If (SaveFileDialog1.ShowDialog() <> DialogResult.OK) Then
            Return
        End If

        ruta = SaveFileDialog1.FileName
        excelApp.Visible = True

        Dim workbook = excelApp.Workbooks.Add()
        Dim worksheet = workbook.ActiveSheet

        worksheet.Cells(1, 1) = "Cajita de Texto de Prueba:"
        worksheet.Cells(2, 1) = txtDato.Text

        workbook.SaveAs(ruta)
    End Sub
End Class
