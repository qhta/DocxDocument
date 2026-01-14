namespace DocumentModel.Wordprocessing;

  /// <summary>
  /// Represents a fixed command keyboard customization in a Wordprocessing document.
  /// This class provides properties for the command name, command index, and argument, enabling configuration and management of keyboard shortcuts for fixed commands.
  /// </summary>
  public class FixedCommandKeyboardCustomization
  {
    
    /// <summary>
    /// Name of the command associated with the keyboard customization.
    /// </summary>
    public string? CommandName { get; set; }
    
    /// <summary>
    /// Index of the command, represented as a hexadecimal character.
    /// </summary>
    public HexChar? CommandIndex { get; set; }
    
    /// <summary>
    /// Argument for the command, represented as a hexadecimal character.
    /// </summary>
    public HexChar? Argument { get; set; }
  }