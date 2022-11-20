namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the PrinterSettingsReference Class.
/// </summary>
public interface IPrinterSettingsReference // : DocumentFormat.OpenXml.Wordprocessing.RelationshipType
{
  /// <summary>
  /// Relationship to Part
  /// </summary>
  public string? Id { get ; set; }
  
}
