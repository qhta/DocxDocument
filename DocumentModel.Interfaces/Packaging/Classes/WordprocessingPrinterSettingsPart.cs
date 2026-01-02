namespace DocumentModel.Packaging;

/// <summary>
///   Defines the WordprocessingPrinterSettingsPart
/// </summary>
public class WordprocessingPrinterSettingsPart: ModelElement
{
  public string? ContentType { get; set; }
  public string? RelationshipType { get; set; }
}