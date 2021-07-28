using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

Namespace usandoHibernate2

    Namespace usandoHibernate2

        Imports NHibernate

        Imports NHibernate.Cfg

        Imports log4net

        Imports System.Configuration

        Imports NHibernate.Connection

        Imports Iesi.Collections
        Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

            Dim mConfig As New Configuration ' Usado para confgurações de inicialização do NHibernate

            'definindo o assembly para carregar os arquivo .hbm.xml  que fazem parte do mesmo

            mConfig.AddAssembly("usandoNHibernate2")

            'definindo o dialeto do banco de dados

            mConfig.SetProperty("hibernate.dialect", "NHibernate.Dialect.MsSql2012Dialect")

            'criando uma sessao e iniciando uma transação

            Dim mFactory As ISessionFactory = mConfig.BuildSessionFactory 'Mantém o mapeamento objeto relacional na memória e permite a criação de objetos session

            Dim mSession As ISession = mFactory.OpenSession 'Permite a comunicação entre a apliação e a persistência

            Dim mTransaction As ITransaction = mSession.BeginTransaction 'Usado para representar uma unidade indivisivel de uma operação de manipulação de dados

            'criando um novo objeto funcionario

            Dim funci As New funcionario

            'obtendo os valores fornecidos no formulario e preenchendo o objeto

            funci.Codigo = textBox1_TextChanged

            funci.Nome = textBox2_TextChanged

            funci.Salario = textBox3_TextChanged
            'persistindo o objeto no banco de dados

            mSession.Save(funci)

            mTransaction.Commit()

            mSession.Close()

            MsgBox("Dados do objeto funcionário foram persistidos com sucesso na tabela : funcionario.")

        End Sub
    End Namespace

