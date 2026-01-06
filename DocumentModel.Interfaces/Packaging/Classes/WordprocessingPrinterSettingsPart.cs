namespace DocumentModel.Packaging;

/// <summary>
///   Defines the WordprocessingPrinterSettingsPart
/// </summary>
public interface WordprocessingPrinterSettingsPart
{
  public string? ContentType { get; set; }
  public string? RelationshipType { get; set; }
}