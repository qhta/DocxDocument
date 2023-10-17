namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Number Literal.
/// </summary>
public partial class NumberLiteral
{
  public DocumentModel.Drawings.Charts.FormatCode? FormatCode { get; set; }
  
  public DocumentModel.Drawings.Charts.PointCount? PointCount { get; set; }
  
  public DocumentModel.Drawings.Charts.ExtensionList? ExtensionList { get; set; }
  
  public DM.ElementCollection<NumericPoint>? Items { get; set; }
  
}
