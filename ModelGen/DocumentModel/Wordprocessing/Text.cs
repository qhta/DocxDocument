namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that this run contains literal text which shall be displayed in the document. The t element shall be used for all text runs which are not:
/// </summary>
public partial class Text: ModelElement<DXW.Text>
{
  public Text(): base(){ }
  
  public Text(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Text(DXW.Text openXmlElement): base(openXmlElement) { }
  
}
