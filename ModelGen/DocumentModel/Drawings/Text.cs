namespace DocumentModel.Drawings;


/// <summary>
///   Defines the Text Class.
/// </summary>
public partial class Text: ModelElement<DXD.Text>
{
  public Text(): base(){ }
  
  public Text(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Text(DXD.Text openXmlElement): base(openXmlElement) { }
  
}
