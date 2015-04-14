﻿using Xpto.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xpto.Domain.Interfaces.Services
{
  public interface IClienteService : IServiceBase<Cliente>
  {
    /// <summary>
    /// Busca os dados do cliente por CPF
    /// </summary>
    /// <param name="Cpf">CPF do cliente</param>
    /// <returns>Retorna o objeto cliente</returns>
    Cliente ObterClientePorCpf(string Cpf);
  }
}
