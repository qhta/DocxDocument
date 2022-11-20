namespace DocumentModel.Wordprocessing;

/// <summary>
/// Script Function to Execute on Form Field Entry.
/// </summary>
public interface IEntryMacro // : DocumentFormat.OpenXml.Wordprocessing.MacroNameType
{
  /// <summary>
  /// Name of Script Function
  /// </summary>
  public string? Val { get ; set; }
  
}
