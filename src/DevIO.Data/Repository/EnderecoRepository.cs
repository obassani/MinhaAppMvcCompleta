﻿using DevIO.Business.Interfaces;
using DevIO.Business.Model;
using DevIO.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Data.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(MeuDbContext context) : base(context)
        {

        }
        public async Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId)
        {
            return await DbContext.Enderecos.AsNoTracking()
                .Include(f => f.Fornecedor)
                .FirstOrDefaultAsync(e => e.FornecedorId == fornecedorId);
        }
    }
}
