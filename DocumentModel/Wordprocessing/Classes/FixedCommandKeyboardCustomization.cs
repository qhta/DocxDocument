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
  public HexChar? CommandIndex { get; set; }

  /// <summary>
  ///   swArg
  /// </summary>
  public HexChar? Argument { get; set; }
}