namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the placeholder text which shall be displayed in place of this custom XML element when the contents of this custom XML markup are empty (i.e. there are no runs of text within the current custom XML element). If this custom XML element does contain run content, then this text shall not be displayed.
/// </summary>
public partial class CustomXmlPlaceholder: ModelElement<DXW.CustomXmlPlaceholder>
{
  public CustomXmlPlaceholder(): base(){ }
  
  public CustomXmlPlaceholder(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CustomXmlPlaceholder(DXW.CustomXmlPlaceholder openXmlElement): base(openXmlElement) { }
  
}
