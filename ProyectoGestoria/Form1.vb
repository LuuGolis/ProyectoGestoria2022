Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DBGestoriaDataSetTramites.TTramites' Puede moverla o quitarla según sea necesario.
        Me.TTramitesTableAdapter.Fill(Me.DBGestoriaDataSetTramites.TTramites)
        'TODO: esta línea de código carga datos en la tabla 'DBGestoriaDataSetClientes.TClientes' Puede moverla o quitarla según sea necesario.
        Me.TClientesTableAdapter.Fill(Me.DBGestoriaDataSetClientes.TClientes)

    End Sub

    'Agregar registro cliente
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.TClientesTableAdapter.agregarCliente(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text)
        Me.TClientesTableAdapter.Fill(Me.DBGestoriaDataSetClientes.TClientes)
    End Sub
    'Modificar clientes
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.TClientesTableAdapter.modificarCliente(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text, TextBox1.Text)
        Me.TClientesTableAdapter.Fill(Me.DBGestoriaDataSetClientes.TClientes)
    End Sub

    'Eliminar registros cliente
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.TClientesTableAdapter.eliminarCliente(TextBox1.Text)
        Me.TClientesTableAdapter.Fill(Me.DBGestoriaDataSetClientes.TClientes)
    End Sub

    'Buscar registros tabla cliente
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.TClientesTableAdapter.buscarClientes(DBGestoriaDataSetClientes.TClientes, TextBox1.Text)
    End Sub

    'Agregar registros tabla tramites
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.TTramitesTableAdapter.agregarTramite(TextBox9.Text, TextBox11.Text, TextBox10.Text, TextBox13.Text, DateTimePicker1.Text, DateTimePicker2.Text, DateTimePicker3.Text, TextBox17.Text, TextBox16.Text, TextBox19.Text, TextBox18.Text)
        Me.TTramitesTableAdapter.Fill(Me.DBGestoriaDataSetTramites.TTramites)
    End Sub

    'Modificar campos tabla tramites segun idtramite
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.TTramitesTableAdapter.modificarTramite(TextBox9.Text, TextBox11.Text, TextBox10.Text, TextBox13.Text, DateTimePicker1.Text, DateTimePicker2.Text, DateTimePicker3.Text, TextBox17.Text, TextBox16.Text, TextBox19.Text, TextBox18.Text, TextBox8.Text, TextBox8.Text)
        Me.TTramitesTableAdapter.Fill(Me.DBGestoriaDataSetTramites.TTramites)
    End Sub

    'Eliminar registro segun idtramite
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.TTramitesTableAdapter.borrarTramite(TextBox8.Text)
        Me.TTramitesTableAdapter.Fill(Me.DBGestoriaDataSetTramites.TTramites)
    End Sub

    'Buscar registros segun idcliente
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.TTramitesTableAdapter.buscarTramite(DBGestoriaDataSetTramites.TTramites, TextBox9.Text)
    End Sub



End Class
