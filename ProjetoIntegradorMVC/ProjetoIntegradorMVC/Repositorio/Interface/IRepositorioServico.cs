﻿using Microsoft.EntityFrameworkCore;
using ProjetoIntegradorMVC.Models.Operacoes;
using ProjetoIntegradorMVC.Models.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoIntegradorMVC.Models.Repositorio.Interface
{
    public interface IRepositorioServico : IRepositorio<Servico>
    {

    }
}
