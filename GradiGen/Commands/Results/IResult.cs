﻿namespace GradiGen.Commands
{
    /// <summary>
    ///     The interface implemented by all result types.
    /// </summary>
    public interface IResult
    {
        /// <summary>
        ///     True if succesful, False if not.
        /// </summary>
        public bool IsSuccess { get; }

        /// <summary>
        ///     The error message. <c>null</c> if not applicable.
        /// </summary>
        public string? Message { get; }

        /// <summary>
        ///     The result's inner exception. <c>null</c> if not applicable.
        /// </summary>
        public Exception? Exception { get; }
    }
}
