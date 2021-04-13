Module Module1
    Sub delay(ByVal dblSecs As Double)
        'codigo empleado para simular un segundo / se llama escribiendo delay()
        Const Onesec As Double = 1.0# / (1440.0# * 60.0#)
        Dim dblwaitil As Date
        Now.AddSeconds(Onesec)
        dblwaitil = Now.AddSeconds(Onesec).AddSeconds(dblSecs)
        Do Until Now > dblwaitil
            Application.DoEvents()
        Loop

    End Sub
End Module
