using System;
using System.Collections.Generic;
using System.Text;
using HarmonyLib;

namespace AtlyssCommandLib.API;

/// <summary>
/// Options for a command. This is a struct to avoid reference issues so you can reuse this without worrying.
/// </summary>
public struct CommandOptions {
    /// <summary>
    /// Whenever this command can be used in chat
    /// </summary>
    public ChatCommandType chatCommand;

    /// <summary>
    /// Whenever this command can be called from the host console.
    /// </summary>
    public bool consoleCmd;

    /// <summary>
    /// Whenever this command is implemented by vanilla or another mod that doesn't use CommandLib.
    /// </summary>
    internal bool mustRunVanillaCode;

    /// <summary>
    /// Default options: chatCommand = Local, consoleCmd = false
    /// </summary>
    public CommandOptions() {
        chatCommand = ChatCommandType.ClientSide;
        consoleCmd = false;
    }

    /// <summary>
    /// Full optional constructor, everything defaults to false
    /// </summary>
    /// <param name="chatCommand"></param>
    /// <param name="consoleCmd"></param>
    public CommandOptions(ChatCommandType chatCommand = ChatCommandType.None, bool consoleCmd = false) {
        this.chatCommand = chatCommand;
        this.consoleCmd = consoleCmd;
    }

    public override string ToString()
    {
        return $"[chatCommand = {chatCommand}, consoleCmd = {consoleCmd}]";
    }
}
