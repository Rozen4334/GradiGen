﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradiGen.Commands
{
    /// <summary>
    ///     An attribute that represents multiple command aliases for quick execution.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class AliasesAttribute : Attribute
    {
        /// <summary>
        ///     The aliases for the target command.
        /// </summary>
        public string[] Aliases { get; }

        /// <summary>
        ///     Creates a new instance of <see cref="AliasesAttribute"/>.
        /// </summary>
        /// <param name="aliases"></param>
        public AliasesAttribute(params string[] aliases)
        {
            Aliases = aliases;
        }
    }
}
