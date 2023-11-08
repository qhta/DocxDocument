namespace DocumentModel.Word10;


/// <summary>
///   Defines the Shade Class.
/// </summary>
public partial class Shade: ModelElement<DXO10W.Shade>
{
  public Shade(): base(){ }
  
  public Shade(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Shade(DXO10W.Shade openXmlElement): base(openXmlElement) { }
  
}
