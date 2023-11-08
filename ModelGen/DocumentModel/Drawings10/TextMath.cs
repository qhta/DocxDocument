namespace DocumentModel.Drawings10;


/// <summary>
///   Defines the TextMath Class.
/// </summary>
public partial class TextMath: ModelElement<DXO10D.TextMath>
{
  public TextMath(): base(){ }
  
  public TextMath(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TextMath(DXO10D.TextMath openXmlElement): base(openXmlElement) { }
  
}
