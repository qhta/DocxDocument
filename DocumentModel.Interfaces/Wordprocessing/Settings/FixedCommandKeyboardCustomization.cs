namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the FixedCommandKeyboardCustomization Class.
/// </summary>
public interface FixedCommandKeyboardCustomization: IModelElement
{
  /// <summary>
  ///   fciName
  /// </summary>
  public string? CommandName { get; set; }
  /// <summary>
  ///   fciIndex
  /// </summary>
  public IHexChar? CommandIndex { get; set; }
  /// <summary>
  ///   swArg
  /// </summary>
  public IHexChar? Argument { get; set; }
}