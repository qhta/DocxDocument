namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the MacroWllType Class.
/// </summary>
public interface MacroWllType: IModelElement
{
  /// <summary>
  ///   macroName
  /// </summary>
  public string? MacroName { get; set; }
}