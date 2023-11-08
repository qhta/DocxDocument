namespace DocumentModel.Wordprocessing;


/// <summary>
///   Rich Text Box Content Container.
/// </summary>
public partial class TextBoxContent: ModelElement<DXW.TextBoxContent>
{
  public TextBoxContent(): base(){ }
  
  public TextBoxContent(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TextBoxContent(DXW.TextBoxContent openXmlElement): base(openXmlElement) { }
  
}
