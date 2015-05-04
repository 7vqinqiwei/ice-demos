' **********************************************************************
'
' Copyright (c) 2003-2015 ZeroC, Inc. All rights reserved.
'
' **********************************************************************

Imports InvokeDemo
Imports System

Module InvokeS

    Class Server
        Inherits Ice.Application

        Public Overloads Overrides Function run(ByVal args() As String) As Integer
            If args.Length > 0 Then
                Console.Error.WriteLine(appName() & ": too many arguments")
                Return 1
            End If

            Dim adapter As Ice.ObjectAdapter = communicator().createObjectAdapter("Printer")
            adapter.add(New PrinterI, communicator().stringToIdentity("printer"))
            adapter.activate()
            communicator.waitForShutdown()
            Return 0
        End Function
    End Class

    Public Sub Main(ByVal args() As String)
        Dim app As Server = New Server
        Dim status As Integer = app.main(args, "config.server")
        System.Environment.Exit(status)
    End Sub
End Module
