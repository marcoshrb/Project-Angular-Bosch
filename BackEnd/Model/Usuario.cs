﻿using System;
using System.Collections.Generic;

namespace BackEnd.Model;

public partial class Usuario
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public string Senha { get; set; } = null!;

    public string Salt { get; set; } = null!;

    public bool Adm { get; set; }
}
