Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

    <Serializable()> Public Class cunit
        Implements ICloneable
    Private ptitle As String
    Private pcomd As Integer
    Private pnation As String
    Private pquality As Integer
    Private prole As String
    Private pstrength As Integer
    Private pmode As String
    Private pentrenched As Boolean
    Private pfire_phase As Boolean
    Private pcover As Integer
    Private pmg As Integer
    Private punderfire As Boolean
    Private pparent As String
    Private psuppression As Integer
    Private pcasualties As Integer
    Private ptask As String
    Private parrives As Integer
    Private pmodifier As Integer
    Private presult As Integer
    Private passault As Boolean
    Private pfatigue As Integer


    Property nation() As String
        Get
            Return pnation
        End Get
        Set(ByVal Value As String)
            pnation = Value
        End Set
    End Property
    Property title() As String
        Get
            Return ptitle
        End Get
        Set(ByVal Value As String)
            ptitle = Value
        End Set
    End Property
    Property comd() As Integer
        Get
            Return pcomd
        End Get
        Set(ByVal Value As Integer)
            pcomd = Value
        End Set
    End Property
    Property role() As String
        Get
            Return prole
        End Get
        Set(ByVal Value As String)
            prole = Value
        End Set
    End Property
    Property strength() As Integer
        Get
            Return pstrength
        End Get
        Set(ByVal Value As Integer)
            pstrength = Value
        End Set
    End Property
    Property quality() As Integer
        Get
            Return pquality
        End Get
        Set(ByVal Value As Integer)
            pquality = Value
        End Set
    End Property
    Property mode() As String
        Get
            Return pmode
        End Get
        Set(ByVal Value As String)
            pmode = Value
        End Set
    End Property
    Property casualties() As Integer
        Get
            Return pcasualties
        End Get
        Set(ByVal Value As Integer)
            pcasualties = Value
        End Set
    End Property
    Property parent() As String
        Get
            Return pparent
        End Get
        Set(ByVal Value As String)
            pparent = Value
        End Set
    End Property
    Property entrenched() As Boolean
        Get
            Return pentrenched
        End Get
        Set(ByVal Value As Boolean)
            pentrenched = Value
        End Set
    End Property
    Property fire_phase() As Boolean
        Get
            Return pfire_phase
        End Get
        Set(ByVal Value As Boolean)
            pfire_phase = Value
        End Set
    End Property
    Property underfire() As Boolean
        Get
            Return punderfire
        End Get
        Set(ByVal Value As Boolean)
            punderfire = Value
        End Set
    End Property
    Property mg() As Integer
        Get
            Return pmg
        End Get
        Set(ByVal Value As Integer)
            pmg = Value
        End Set
        End Property
        Property assault() As Boolean
            Get
                Return passault
            End Get
            Set(ByVal Value As Boolean)
                passault = Value
            End Set
        End Property
    Property result() As Integer
        Get
            Return presult
        End Get
        Set(ByVal Value As Integer)
            presult = Value
        End Set
    End Property
    Property modifier() As Integer
            Get
                Return pmodifier
            End Get
            Set(ByVal Value As Integer)
                pmodifier = Value
            End Set
        End Property
    Property task() As String
        Get
            Return ptask
        End Get
        Set(ByVal Value As String)
            ptask = Value
        End Set
    End Property
    Property suppression() As Integer
        Get
            Return psuppression
        End Get
        Set(ByVal Value As Integer)
            psuppression = Value
        End Set
    End Property
    Property Cover() As Integer
        Get
            Return pcover
        End Get
        Set(ByVal Value As Integer)
            pcover = Value
        End Set
    End Property
    Property fatigue() As Integer
        Get
            Return pfatigue
        End Get
        Set(ByVal Value As Integer)
            pfatigue = Value
        End Set
    End Property
    Property arrives() As Integer
        Get
            Return parrives
        End Get
        Set(ByVal Value As Integer)
            parrives = Value
        End Set
    End Property
    Public Function Clone() As Object Implements System.ICloneable.Clone
        Dim m As New MemoryStream()
        Dim f As New BinaryFormatter()
        f.Serialize(m, Me)
        m.Seek(0, SeekOrigin.Begin)
        Return f.Deserialize(m)
    End Function

End Class
