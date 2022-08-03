﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradiGen.Commands
{
    /// <summary>
    ///     Represents the required info to map a command.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class CommandAttribute : Attribute
    {
        /// <summary>
        ///     The command name.
        /// </summary>
        public string Name { get; }

        /// <summary>
        ///     The command description.
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        public CommandAttribute(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
