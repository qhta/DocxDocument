namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the ThemeColorValues enumeration.
/// </summary>
public partial class ThemeColorValues: ModelElement<DXW.ThemeColorValues>
{
  public ThemeColorValues(): base(){ }
  
  public ThemeColorValues(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ThemeColorValues(DXW.ThemeColorValues openXmlElement): base(openXmlElement) { }
  
}
