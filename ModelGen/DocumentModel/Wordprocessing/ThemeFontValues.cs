namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the ThemeFontValues enumeration.
/// </summary>
public partial class ThemeFontValues: ModelElement<DXW.ThemeFontValues>
{
  public ThemeFontValues(): base(){ }
  
  public ThemeFontValues(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ThemeFontValues(DXW.ThemeFontValues openXmlElement): base(openXmlElement) { }
  
}
