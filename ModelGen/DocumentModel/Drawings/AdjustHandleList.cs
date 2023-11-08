namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies the adjust handles that are applied to a custom geometry. These adjust handles specify points within the geometric shape that can be used to perform certain transform operations on the shape.
/// </summary>
public partial class AdjustHandleList: ModelElement<DXD.AdjustHandleList>
{
  public AdjustHandleList(): base(){ }
  
  public AdjustHandleList(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public AdjustHandleList(DXD.AdjustHandleList openXmlElement): base(openXmlElement) { }
  
}
