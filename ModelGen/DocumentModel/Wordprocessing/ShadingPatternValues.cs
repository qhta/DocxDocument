namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the ShadingPatternValues enumeration.
/// </summary>
public partial class ShadingPatternValues: ModelElement<DXW.ShadingPatternValues>
{
  public ShadingPatternValues(): base(){ }
  
  public ShadingPatternValues(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ShadingPatternValues(DXW.ShadingPatternValues openXmlElement): base(openXmlElement) { }
  
}
