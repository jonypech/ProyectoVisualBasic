Public Class Form1
    Dim conexion As Conexion = New Conexion()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.conectar()
        MostrarDatos()

    End Sub

    Public Sub MostrarDatos()
        conexion.consulta("select * from alumnos", "alumnos")
        datos.DataSource = conexion.ds.Tables("alumnos")
        datos.Columns(0).HeaderText = "ID"
        datos.Columns(1).HeaderText = "NOMBRE"
        datos.Columns(2).HeaderText = "APELLIDOS"
        datos.Columns(3).HeaderText = "MATERIA 1"
        datos.Columns(4).HeaderText = "MATERIA 2"
        datos.Columns(5).HeaderText = "MATERIA 3"
        datos.Columns(6).HeaderText = "MATERIA 4"
        datos.Columns(7).HeaderText = "MATERIA 5"
        datos.Columns(8).HeaderText = "MATERIA 6"
        datos.AutoResizeColumns()
        datos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
    End Sub

    Private Sub guardarbtn_Click(sender As Object, e As EventArgs) Handles guardarbtn.Click
        Dim guardar As String = "Insert Into alumnos values ('" + nombretxt.Text + "','" + apellidotxt.Text + "','" + mat1txt.Text + "','" + mat2txt.Text + "','" + mat3txt.Text + "','" + mat4txt.Text + "','" + mat5txt.Text + "','" + mat6txt.Text + "')"
        If (conexion.insertar(guardar)) Then
            MessageBox.Show("Datos guardados correctamente")
            MostrarDatos()
        Else
            MessageBox.Show("Error al agregar")
        End If
    End Sub

    Private Sub datos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datos.CellContentClick
        Dim dgv As DataGridViewRow = datos.Rows(e.RowIndex)
        clavetxt.Text = dgv.Cells(0).Value.ToString
        nombretxt.Text = dgv.Cells(1).Value.ToString
        apellidotxt.Text = dgv.Cells(2).Value.ToString
        mat1txt.Text = dgv.Cells(3).Value.ToString
        mat2txt.Text = dgv.Cells(4).Value.ToString
        mat3txt.Text = dgv.Cells(5).Value.ToString
        mat4txt.Text = dgv.Cells(6).Value.ToString
        mat5txt.Text = dgv.Cells(7).Value.ToString
        mat6txt.Text = dgv.Cells(8).Value.ToString
    End Sub

    Private Sub eliminarbtn_Click(sender As Object, e As EventArgs) Handles eliminarbtn.Click
        If (conexion.eliminar("alumnos", "id = " + clavetxt.Text)) Then
            MessageBox.Show("Datos eliminados")
            MostrarDatos()
        Else
            MessageBox.Show("Error al eliminar datos")
        End If
    End Sub

    Private Sub modificarbtn_Click(sender As Object, e As EventArgs) Handles modificarbtn.Click
        Dim actualizar As String = "nombre = '" + nombretxt.Text + ", apellido = '" + apellidotxt.Text + ", cal1 = '" + mat1txt.Text + ", cal2 = '" + mat2txt.Text + ", cal3 = '" + mat3txt.Text + ", cal4 = '" + mat4txt.Text + ", cal5 = '" + mat5txt.Text + ", cal6 = '" + mat6txt.Text
        If (conexion.actualizar("alumnos", actualizar, "clave = " + clavetxt.Text)) Then
            MessageBox.Show("Datos actualizados")
            MostrarDatos()
        Else
            MessageBox.Show("Erros al actualizar datos")
        End If
    End Sub

    Private Sub limpiarbtn_Click(sender As Object, e As EventArgs) Handles limpiarbtn.Click
        clavetxt.Text = ""
        nombretxt.Text = ""
        apellidotxt.Text = ""
        mat1txt.Text = ""
        mat2txt.Text = ""
        mat3txt.Text = ""
        mat4txt.Text = ""
        mat5txt.Text = ""
        mat6txt.Text = ""
        MostrarDatos()
    End Sub
End Class
