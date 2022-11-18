namespace DocumentModel.Wordprocessing;

/// <summary>
/// Script Function to Execute on Form Field Exit.
/// </summary>
public interface IExitMacro // : DocumentFormat.OpenXml.Wordprocessing.MacroNameType
{
  /// <summary>
  /// Name of Script Function
  /// </summary>
  public string? Val { get ; set; }
  
}
