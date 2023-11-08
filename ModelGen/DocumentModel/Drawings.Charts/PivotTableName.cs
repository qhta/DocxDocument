namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Pivot Name.
/// </summary>
public partial class PivotTableName: ModelElement<DXDC.PivotTableName>
{
  public PivotTableName(): base(){ }
  
  public PivotTableName(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PivotTableName(DXDC.PivotTableName openXmlElement): base(openXmlElement) { }
  
}
