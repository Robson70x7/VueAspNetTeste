using System;
using Todo.Domain.EntitiesValidators;
using Todo.Domain.Enuns;
using Todo.Domain.Shared;

namespace Todo.Domain
{
    public class Task : Entity
    {
        public string Descricao { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public DateTime? DataFinalizacao{get; private set;}
        public StatusTask Status{get;private set;}
        public string Responsavel { get; private set; }
        
        protected Task()
        {} //EF

        public Task(int id, string descricao, DateTime dataCriacao, DateTime? dataFinalizacao, string responsavel)
        {
            Id = id;
            Descricao = descricao;
            DataCriacao = dataCriacao;
            DataFinalizacao = dataFinalizacao;
            Responsavel = responsavel;
            Status = StatusTask.Init;
        }
        public void DoneTask()
        {
            Status = StatusTask.Done;
            DataFinalizacao = DateTime.Now;
        }

        public void StartTask(){
            Status = StatusTask.Doing;
        }

        public override string ToString()
        {
            return $"{Descricao}\n{Status.ToString()} {DataCriacao.ToShortDateString()}";
        }

        public bool EhValido()
        {
            ValidationResult = new TaskValidator().Validate(this);

            return ValidationResult.IsValid;
        }
    }
}