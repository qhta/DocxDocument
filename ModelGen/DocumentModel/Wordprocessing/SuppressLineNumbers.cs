namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies whether line numbers shall be calculated for lines in this paragraph by the consumer when line numbering is requested using the lnNumType element
/// </summary>
public partial class SuppressLineNumbers: ModelElement<DXW.SuppressLineNumbers>
{
  public SuppressLineNumbers(): base(){ }
  
  public SuppressLineNumbers(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SuppressLineNumbers(DXW.SuppressLineNumbers openXmlElement): base(openXmlElement) { }
  
}
