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
  public HexBinaryValue? CommandIndex { get ; set; }
  
  /// <summary>
  /// swArg
  /// </summary>
  public HexBinaryValue? Argument { get ; set; }
  
}
