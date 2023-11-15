namespace DocumentModel.Drawings;


/// <summary>
///   Defines the HyperlinkOnClick Class.
/// </summary>
public partial class HyperlinkOnClick: ModelElement<DXD.HyperlinkOnClick>
{
  public HyperlinkOnClick(): base(){ }
  
  public HyperlinkOnClick(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public HyperlinkOnClick(DXD.HyperlinkOnClick openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMD.HyperlinkSound? HyperlinkSound
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.EmbeddedWavAudioFileType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.EmbeddedWavAudioFileType");
  }
  
  [DataMember]
  public DMD.HyperlinkExtensionList? HyperlinkExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
