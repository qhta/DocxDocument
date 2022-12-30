namespace DocumentModel.Drawings.Charts;

/// <summary>
/// String Literal.
/// </summary>
public partial class StringLiteral
{
  public UInt32? PointCount { get; set; }
  
  public Collection<DocumentModel.Drawings.Charts.StringPoint>? StringPoints { get; set; }
  
  public DocumentModel.Drawings.Charts.StrDataExtensionList? StrDataExtensionList { get; set; }
  
}
