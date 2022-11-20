namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the PrinterSettingsReference Class.
/// </summary>
public class PrinterSettingsReference: IPrinterSettingsReference
{
  /// <summary>
  /// Relationship to Part
  /// </summary>
  public string? Id
  {
    get;
    set;
  }
  
}
