﻿using MusicBit.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MusicBit.Core.Interfaces
{
    public interface IPostRepository
    {
        Task<IEnumerable<Artistum>> GetPosts();
    }
}
