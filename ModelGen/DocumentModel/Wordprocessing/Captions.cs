namespace DocumentModel.Wordprocessing;


/// <summary>
///   Caption Settings.
/// </summary>
public partial class Captions: ModelElement<DXW.Captions>
{
  public Captions(): base(){ }
  
  public Captions(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Captions(DXW.Captions openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMW.AutoCaptions? AutoCaptions
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
