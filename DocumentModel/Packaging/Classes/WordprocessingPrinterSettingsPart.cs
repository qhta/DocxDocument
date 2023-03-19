namespace DocumentModel.Packaging;

/// <summary>
///   Defines the WordprocessingPrinterSettingsPart
/// </summary>
public class WordprocessingPrinterSettingsPart: ModelElement
{
  public String? ContentType { get; set; }

  public String? RelationshipType { get; set; }
}