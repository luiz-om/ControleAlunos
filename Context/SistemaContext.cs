using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ControleAulnos.Context
{
    public class SistemaContext : DbContext
    {
        //criar construtor e indicar na base("") o nome da conexão
        public SistemaContext() : base("DefaultConnection")
        {

        }

        //trabalhar a abertura e o fechamento do context
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}