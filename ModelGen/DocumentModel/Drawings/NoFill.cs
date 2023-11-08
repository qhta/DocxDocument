namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies that no fill is applied to the parent element.
/// </summary>
public partial class NoFill: ModelElement<DXD.NoFill>
{
  public NoFill(): base(){ }
  
  public NoFill(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NoFill(DXD.NoFill openXmlElement): base(openXmlElement) { }
  
}
