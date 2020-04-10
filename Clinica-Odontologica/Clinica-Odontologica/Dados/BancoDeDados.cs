using Clinica_Odontologica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica_Odontologica.Dados
{
    public class BancoDeDados
    {
        public static List<Paciente> pacientes;
        public static List<Procedimento> procedimentos;
        public static BancoDeDados instance;

        public static BancoDeDados Instance()
        {
            if (instance == null)
            {
                pacientes = new List<Paciente>();
                procedimentos = new List<Procedimento>();
                instance = new BancoDeDados();
            }
            return instance;
        }
        public void Add(Paciente paciente)
        {
            pacientes.Add(paciente);
        }
        public List<Paciente> GetPacientes()
        {
            return pacientes;
        }
        public void Remover(int id)
        {
            Paciente pacienteParaRemover = pacientes.Where(l => l.Id == id).FirstOrDefault();
            pacientes.Remove(pacienteParaRemover);
        }

        public void Add(Procedimento procedimento)
        {
            procedimentos.Add(procedimento);
        }
        public List<Procedimento> GetProcedimentos()
        {
            return procedimentos;
        }
    }
}
