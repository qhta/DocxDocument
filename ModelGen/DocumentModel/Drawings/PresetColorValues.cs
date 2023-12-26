namespace DocumentModel.Drawings;


/// <summary>
///   Preset Color Value
/// </summary>
public partial class PresetColorValues: ModelElement<DXD.PresetColorValues>
{
  public PresetColorValues(): base(){ }
  
  public PresetColorValues(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PresetColorValues(DXD.PresetColorValues openXmlElement): base(openXmlElement) { }
  
}
