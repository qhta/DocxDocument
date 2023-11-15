namespace DocumentModel.Drawings;


/// <summary>
///   Defines the HyperlinkOnMouseOver Class.
/// </summary>
public partial class HyperlinkOnMouseOver: ModelElement<DXD.HyperlinkOnMouseOver>
{
  public HyperlinkOnMouseOver(): base(){ }
  
  public HyperlinkOnMouseOver(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public HyperlinkOnMouseOver(DXD.HyperlinkOnMouseOver openXmlElement): base(openXmlElement) { }
  
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
