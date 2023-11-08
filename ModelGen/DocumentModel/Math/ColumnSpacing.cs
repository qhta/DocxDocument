namespace DocumentModel.Math;


/// <summary>
///   Matrix Column Spacing.
/// </summary>
public partial class ColumnSpacing: ModelElement<DXM.ColumnSpacing>
{
  public ColumnSpacing(): base(){ }
  
  public ColumnSpacing(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ColumnSpacing(DXM.ColumnSpacing openXmlElement): base(openXmlElement) { }
  
}
