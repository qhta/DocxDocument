namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the XValues Class.
/// </summary>
public partial class XValues
{
  public DocumentModel.Drawings.Charts.MultiLevelStringReference? MultiLevelStringReference { get; set; }
  
  public DocumentModel.Drawings.Charts.NumberReference? NumberReference { get; set; }
  
  public DocumentModel.Drawings.Charts.NumberLiteral? NumberLiteral { get; set; }
  
  public DocumentModel.Drawings.Charts.StringReference? StringReference { get; set; }
  
  public DocumentModel.Drawings.Charts.StringLiteral? StringLiteral { get; set; }
  
}
