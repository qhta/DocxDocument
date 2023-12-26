namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the TextEffectValues enumeration.
/// </summary>
public partial class TextEffectValues: ModelElement<DXW.TextEffectValues>
{
  public TextEffectValues(): base(){ }
  
  public TextEffectValues(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TextEffectValues(DXW.TextEffectValues openXmlElement): base(openXmlElement) { }
  
}
