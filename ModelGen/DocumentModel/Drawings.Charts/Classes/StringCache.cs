namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the StringCache Class.
/// </summary>
public partial class StringCache
{
  public DocumentModel.Drawings.Charts.PointCount? PointCount { get; set; }
  
  public DocumentModel.Drawings.Charts.StrDataExtensionList? StrDataExtensionList { get; set; }
  
  public DM.ElementCollection<StringPoint>? Items { get; set; }
  
}
