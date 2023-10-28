namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the XValues Class.
/// </summary>
public partial class XValues
{
  public DMDC.MultiLevelStringReference? MultiLevelStringReference { get; set; }
  
  public DMDC.NumberReference? NumberReference { get; set; }
  
  public DMDC.NumberLiteral? NumberLiteral { get; set; }
  
  public DMDC.StringReference? StringReference { get; set; }
  
  public DMDC.StringLiteral? StringLiteral { get; set; }
  
}
