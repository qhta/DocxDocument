namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the FixedCommandKeyboardCustomization Class.
/// </summary>
public class FixedCommandKeyboardCustomization
{
  /// <summary>
  ///   fciName
  /// </summary>
  public String? CommandName { get; set; }

  /// <summary>
  ///   fciIndex
  /// </summary>
  public UInt16? CommandIndex { get; set; }

  /// <summary>
  ///   swArg
  /// </summary>
  public UInt16? Argument { get; set; }
}