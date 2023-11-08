namespace DocumentModel.Wordprocessing;


/// <summary>
///   Display Background Objects When Displaying Document.
/// </summary>
public partial class DisplayBackgroundShape: ModelElement<DXW.DisplayBackgroundShape>
{
  public DisplayBackgroundShape(): base(){ }
  
  public DisplayBackgroundShape(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DisplayBackgroundShape(DXW.DisplayBackgroundShape openXmlElement): base(openXmlElement) { }
  
}
