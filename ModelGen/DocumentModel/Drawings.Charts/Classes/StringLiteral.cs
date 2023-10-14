namespace DocumentModel.Drawings.Charts;


/// <summary>
///   String Literal.
/// </summary>
public partial class StringLiteral
{
  public DocumentModel.Drawings.Charts.PointCount? PointCount { get; set; }
  
  public DocumentModel.Drawings.Charts.StrDataExtensionList? StrDataExtensionList { get; set; }
  
  public DM.ElementCollection<StringPoint>? Items { get; set; }
  
}
