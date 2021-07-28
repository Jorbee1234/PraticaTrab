using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

Namespace usandoHibernate2

    pubic Class funcionario

        Private _codigo As Int32
        Private _salario As Decimal
        Private _nome As String

        Public Sub New() 'Cria um construtor vazio
        End Sub


        Public Overridable Property Codigo() As Int32 'O overridable declara que o metodo pode ser sobreposto nas classes que herdarem a classe base
            Get 'Está dando um get em relação ao codigo
                Return _codigo 'Retorna o codigo
            End Get 'Fechando o Get'
            Set(ByVal value As Int32) 'Está pegando o valor e colocando dentro do codigo
                _codigo = value 'Passando valor
            End Set 'Termina o Set'
        End Property

        Public Overridable Property Nome() As String
            Get
                Return _nome
            End Get
            Set(ByVal value As String)
                _nome = value
            End Set
        End Property

        Public Overridable Property Salario() As Decimal
            Get
                Return _salario
            End Get
            Set(ByVal value As Decimal)
                _salario = value
            End Set
        End Property


    End Class

End Namespace

