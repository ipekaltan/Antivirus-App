Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class MyButton

    Inherits Button

    Private m_Topcolor As Color = Color.LightGreen
    Private m_BottomColor As Color = Color.Orange

    Public Property TopColor As Color
        Get
            Return m_Topcolor
        End Get
        Set(value As Color)
            m_Topcolor = value
            Me.Invalidate()
        End Set
    End Property

    Public Property BottomColor As Color
        Get
            Return m_BottomColor
        End Get
        Set(value As Color)
            m_BottomColor = value
            Me.Invalidate()
        End Set
    End Property

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)

        Using lgb As LinearGradientBrush = New LinearGradientBrush(Me.ClientRectangle, m_Topcolor, m_BottomColor, 90.0F)
            Using textBrush As SolidBrush = New SolidBrush(Me.ForeColor)
                Using format As StringFormat = New StringFormat()
                    format.Alignment = GetHorizontalAlignment()
                    format.LineAlignment = GetVerticalAlignment()
                    e.Graphics.FillRectangle(lgb, Me.ClientRectangle)
                    e.Graphics.DrawString(Me.Text, Me.Font, textBrush, Me.ClientRectangle, format)
                End Using
            End Using
        End Using
    End Sub

    Private Function GetVerticalAlignment() As StringAlignment
        Return CType(Math.Log(Me.TextAlign, 2D) / 4, StringAlignment)
    End Function

    Private Function GetHorizontalAlignment() As StringAlignment
        Return CType(Math.Log(Me.TextAlign, 2D) Mod 4, StringAlignment)
    End Function

End Class
