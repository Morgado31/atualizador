Module MVariables

    Public outputTrabalhador As String

    Private server As String = "minasdb2.chljmxp9y4pm.eu-west-3.rds.amazonaws.com"
    Private database As String = "Minas2"
    Private uid As String = "minas2"
    Private password As String = "orgminas2"

    Public connString As String = "server=" & server & ";userid=" & uid & ";password=" & password & ";database=" & database

End Module
