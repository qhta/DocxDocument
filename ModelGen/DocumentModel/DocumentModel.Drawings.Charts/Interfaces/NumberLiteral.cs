namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Number Literal.
/// </summary>
public partial interface NumberLiteral
{
  public String? FormatCode { get; set; }
  
  public UInt32? PointCount { get; set; }
  
  public Collection<DocumentModel.Drawings.Charts.NumericPoint>? NumericPoints { get; set; }
  
  public DocumentModel.Drawings.Charts.ExtensionList? ExtensionList { get; set; }
  
}
