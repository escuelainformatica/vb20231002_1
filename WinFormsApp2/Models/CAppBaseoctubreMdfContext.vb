Imports System
Imports System.Collections.Generic
Imports Microsoft.EntityFrameworkCore

Namespace Models
    Partial Public Class CAppBaseoctubreMdfContext
        Inherits DbContext

        Public Sub New()
        End Sub

        Public Sub New(options As DbContextOptions(Of CAppBaseoctubreMdfContext))
            MyBase.New(options)
        End Sub

        Public Overridable Property Productos As DbSet(Of Producto)

        Protected Overrides Sub OnConfiguring(optionsBuilder As DbContextOptionsBuilder)
            'TODO /!\ To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
            optionsBuilder.UseSqlServer("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\app\BASEOCTUBRE.mdf;Integrated Security=True;Connect Timeout=30")
        End Sub

        Protected Overrides Sub OnModelCreating(modelBuilder As ModelBuilder)
            modelBuilder.UseCollation("Modern_Spanish_CI_AS")

            modelBuilder.Entity(Of Producto)(
                Sub(entity)
                    entity.HasKey(Function(e) e.Id).HasName("PK__Producto__3214EC07632988FB")

                    entity.Property(Function(e) e.Id).ValueGeneratedNever()
                    entity.Property(Function(e) e.Nombre).
                        HasMaxLength(50).
                        IsUnicode(False)
                End Sub)

            OnModelCreatingPartial(modelBuilder)
        End Sub

        Partial Private Sub OnModelCreatingPartial(modelBuilder As ModelBuilder)
        End Sub
    End Class
End Namespace
