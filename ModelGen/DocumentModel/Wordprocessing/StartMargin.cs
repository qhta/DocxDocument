namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the border which shall be displayed on the leading edge of the current table cell (left for LTR tables, right for RTL tables). The appearance of this table cell border in the document shall be determined by the following settings:
/// </summary>
public partial class StartMargin: ModelElement<DXW.StartMargin>
{
  public StartMargin(): base(){ }
  
  public StartMargin(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public StartMargin(DXW.StartMargin openXmlElement): base(openXmlElement) { }
  
}
