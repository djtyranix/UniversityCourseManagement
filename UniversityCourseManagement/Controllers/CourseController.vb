Imports System.Web.Mvc

Namespace UniversityCourseManagement
    Public Class CourseController
        Inherits Controller

        ' GET: Course
        Function Course() As ActionResult
            Return View()
        End Function
    End Class
End Namespace