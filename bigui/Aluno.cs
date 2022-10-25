using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bigui
{
    class Aluno
    {
        public double ra;
        public string Nome;
        public double n1;
        public double n2;
        public double n3;
        public double n4;
        public double media;
        public string situacao;

      
        public void Calcmedia()
        {
            
                media = ((n1 * 2) + (n2 * 3) + (n3 * 2) + (n4 * 3)) / 10;
             
        }
        public void defSituacao()
        { 
            if (this.media < 4)
            {
                this.situacao = "Reprovado";
            }
            else if  (this.media < 6)
            {
                this.situacao = "Recuperação";
            }
            else
            {
                this.situacao = "Aprovado";
            }
        }
    }
}

    
    

