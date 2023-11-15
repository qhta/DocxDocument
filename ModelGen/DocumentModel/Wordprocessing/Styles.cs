namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies all of the style information stored in the WordprocessingML document: style definitions as well as latent style information.
/// </summary>
public partial class Styles: ModelElement<DXW.Styles>
{
  public Styles(): base(){ }
  
  public Styles(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Styles(DXW.Styles openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Document Default Paragraph and Run Properties.
  /// </summary>
  [DataMember]
  public DMW.DocDefaults? DocDefaults
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Latent Style Information.
  /// </summary>
  [DataMember]
  public DMW.LatentStyles? LatentStyles
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
