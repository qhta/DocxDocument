namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FixedCommandKeyboardCustomization Class.
/// </summary>
public interface FixedCommandKeyboardCustomization
{
  /// <summary>
  /// fciName
  /// </summary>
  public String? CommandName { get ; set; }
  
  /// <summary>
  /// fciIndex
  /// </summary>
  public DocumentModel.HexBinary? CommandIndex { get ; set; }
  
  /// <summary>
  /// swArg
  /// </summary>
  public DocumentModel.HexBinary? Argument { get ; set; }
  
}
