using System;

namespace Cassia
{
    /// <summary>
    /// Wraps the native terminal server handle.
    /// </summary>
    public interface ITerminalServerHandle : IDisposable
    {
        /// <summary>
        /// The underlying terminal server handle provided by Windows in a call to WTSOpenServer.
        /// </summary>
        IntPtr Handle { get; }

        /// <summary>
        /// The name of the terminal server for this connection.
        /// </summary>
        string ServerName { get; }

        /// <summary>
        /// Returns <c>true</c> if the connection to the server is currently open.
        /// </summary>
        bool IsOpen { get; }

        /// <summary>
        /// Opens the terminal server handle.
        /// </summary>
        void Open();

        /// <summary>
        /// Closes the terminal server handle.
        /// </summary>
        void Close();
    }
}