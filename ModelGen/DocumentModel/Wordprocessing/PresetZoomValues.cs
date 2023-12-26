namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the PresetZoomValues enumeration.
/// </summary>
public partial class PresetZoomValues: ModelElement<DXW.PresetZoomValues>
{
  public PresetZoomValues(): base(){ }
  
  public PresetZoomValues(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PresetZoomValues(DXW.PresetZoomValues openXmlElement): base(openXmlElement) { }
  
}
