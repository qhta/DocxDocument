namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the TextType Class.
/// </summary>
public partial class TextType: ModelElement<DXW.TextType>
{
  public TextType(): base(){ }
  
  public TextType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TextType(DXW.TextType openXmlElement): base(openXmlElement) { }
  
}
