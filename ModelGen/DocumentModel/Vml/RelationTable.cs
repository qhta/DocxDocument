namespace DocumentModel.Vml;


/// <summary>
///   Diagram Relationship Table.
/// </summary>
public partial class RelationTable: ModelElement<DXVO.RelationTable>
{
  public RelationTable(): base(){ }
  
  public RelationTable(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public RelationTable(DXVO.RelationTable openXmlElement): base(openXmlElement) { }
  
}
