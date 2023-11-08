namespace DocumentModel.Wordprocessing;


/// <summary>
///   Allow Automatic Formatting to Override Formatting Protection Settings.
/// </summary>
public partial class AutoFormatOverride: ModelElement<DXW.AutoFormatOverride>
{
  public AutoFormatOverride(): base(){ }
  
  public AutoFormatOverride(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public AutoFormatOverride(DXW.AutoFormatOverride openXmlElement): base(openXmlElement) { }
  
}
