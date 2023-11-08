namespace DocumentModel.Wordprocessing;


/// <summary>
///   Theme Color Mappings.
/// </summary>
public partial class ColorSchemeMapping: ModelElement<DXW.ColorSchemeMapping>
{
  public ColorSchemeMapping(): base(){ }
  
  public ColorSchemeMapping(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ColorSchemeMapping(DXW.ColorSchemeMapping openXmlElement): base(openXmlElement) { }
  
}
