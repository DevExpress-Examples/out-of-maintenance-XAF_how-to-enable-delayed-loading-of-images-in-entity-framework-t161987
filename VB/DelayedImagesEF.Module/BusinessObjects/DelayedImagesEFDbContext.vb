Imports System
Imports System.Linq
Imports System.Data.Entity
Imports System.Data.Common
Imports System.ComponentModel
Imports DevExpress.ExpressApp.EF.Updating
Imports DevExpress.Persistent.Base
Imports DevExpress.ExpressApp.EF.Utils
Imports DevExpress.ExpressApp.DC
Imports DevExpress.ExpressApp

Namespace DelayedImagesEF.Module.BusinessObjects
    Public Class DelayedImagesEFDbContext
        Inherits DbContext

        Public Sub New(ByVal connectionString As String)
            MyBase.New(connectionString)
        End Sub
        Public Sub New(ByVal connection As DbConnection)
            MyBase.New(connection, False)
        End Sub
        Public Property ModulesInfo() As DbSet(Of ModuleInfo)
        Public Property SampleObjects() As DbSet(Of SampleObject)
        Public Property DelayedImages() As DbSet(Of DelayedImage)
    End Class
    <DefaultClassOptions> _
    Public Class SampleObject
        Implements IXafEntityObject

        Private privateId As Integer
        <Browsable(False)> _
        Public Property Id() As Integer
            Get
                Return privateId
            End Get
            Protected Set(ByVal value As Integer)
                privateId = value
            End Set
        End Property
        Public Property Name() As String
        <Delayed, ExpandObjectMembers(ExpandObjectMembers.Always)> _
        Public Overridable Property Image() As DelayedImage
        Public Sub OnCreated() Implements IXafEntityObject.OnCreated
            Image = New DelayedImage()
        End Sub
        Public Sub OnLoaded() Implements IXafEntityObject.OnLoaded
        End Sub
        Public Sub OnSaving() Implements IXafEntityObject.OnSaving
        End Sub
    End Class
    Public Class DelayedImage
        Private privateId As Integer
        <Browsable(False)> _
        Public Property Id() As Integer
            Get
                Return privateId
            End Get
            Protected Set(ByVal value As Integer)
                privateId = value
            End Set
        End Property
        <ImageEditor, Delayed, VisibleInListView(True), XafDisplayName("Image")> _
        Public Property ImageData() As Byte()
    End Class

End Namespace