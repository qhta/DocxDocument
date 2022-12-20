namespace DocumentModel.Packaging;

/// <summary>
/// Defines the WordprocessingPrinterSettingsPart
/// </summary>
public partial interface WordprocessingPrinterSettingsPart
{
  public String? ContentType { get; }
  
  public String? RelationshipType { get; }
  
}
