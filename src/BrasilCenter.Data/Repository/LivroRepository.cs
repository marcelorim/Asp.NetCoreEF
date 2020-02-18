using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BrasilCenter.Business.Interfaces;
using BrasilCenter.Business.Models;
using Microsoft.EntityFrameworkCore;

namespace BrasilCenter.Data.Repository
{
    public class LivroRepository : Repository<Livro>, ILivroRepository
    {
        
    }
}
