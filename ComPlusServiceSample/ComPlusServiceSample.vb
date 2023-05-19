Imports System.EnterpriseServices
Imports System.Reflection

<Assembly: ApplicationName("ComPlusServiceSample")>
<Assembly: AssemblyKeyFile("./bin/Debug/ComPlusServiceSample.snk")>

<Transaction(TransactionOption.Required)>
Public Class ComPlusServiceSample
    Inherits ServicedComponent

    Public Sub New()
        MyBase.New()
    End Sub

    <AutoComplete()> Public Function DoTransaction() As String
        Return "Servicio COM+ Funciona correctamente..."
    End Function

End Class
