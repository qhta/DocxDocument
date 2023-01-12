namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FixedCommandKeyboardCustomization Class.
/// </summary>
public partial class FixedCommandKeyboardCustomization
{
  /// <summary>
  /// fciName
  /// </summary>
  public String? CommandName { get; set; }
  
  /// <summary>
  /// fciIndex
  /// </summary>
  public Byte[]? CommandIndex { get; set; }
  
  /// <summary>
  /// swArg
  /// </summary>
  public Byte[]? Argument { get; set; }
  
}
