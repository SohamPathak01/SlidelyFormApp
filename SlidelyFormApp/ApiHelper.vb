Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class ApiHelper
    Private Shared ReadOnly client As HttpClient = New HttpClient()

    Public Shared Async Function PostAsync(url As String, data As Object) As Task(Of HttpResponseMessage)
        Dim json As String = JsonConvert.SerializeObject(data)
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")
        Dim response As HttpResponseMessage = Await client.PostAsync(url, content)
        Return response
    End Function

    Public Shared Async Function GetAsync(url As String) As Task(Of HttpResponseMessage)
        Dim response As HttpResponseMessage = Await client.GetAsync(url)
        Return response
    End Function
End Class
