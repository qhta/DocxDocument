namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies whether the current paragraph should use the document grid lines per page settings defined in the docGrid element
/// </summary>
public partial class SnapToGrid: ModelElement<DXW.SnapToGrid>
{
  public SnapToGrid(): base(){ }
  
  public SnapToGrid(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SnapToGrid(DXW.SnapToGrid openXmlElement): base(openXmlElement) { }
  
}
