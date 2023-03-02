namespace DocumentModel.Packaging;

/// <summary>
///   Defines the WordprocessingPrinterSettingsPart
/// </summary>
public record WordprocessingPrinterSettingsPart
{
  public String? ContentType { get; set; }

  public String? RelationshipType { get; set; }
}