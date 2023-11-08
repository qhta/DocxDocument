namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that all small letter characters in this text run shall be formatted for display only as their capital letter character equivalents in a font size two points smaller than the actual font size specified for this text. This property does not affect any non-alphabetic character in this run and does not change the Unicode character for lowercase text, only the method in which it is displayed. If this font cannot be made two point smaller than the current size, then it shall be displayed as the smallest possible font size in capital letters.
/// </summary>
public partial class SmallCaps: ModelElement<DXW.SmallCaps>
{
  public SmallCaps(): base(){ }
  
  public SmallCaps(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SmallCaps(DXW.SmallCaps openXmlElement): base(openXmlElement) { }
  
}
