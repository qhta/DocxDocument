namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the FixedCommandKeyboardCustomization Class.
/// </summary>
public class FixedCommandKeyboardCustomization: ModelElement
{
  /// <summary>
  ///   fciName
  /// </summary>
  public string? CommandName { get; set; }

  /// <summary>
  ///   fciIndex
  /// </summary>
  public HexChar? CommandIndex { get; set; }

  /// <summary>
  ///   swArg
  /// </summary>
  public HexChar? Argument { get; set; }
}