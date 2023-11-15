namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the contents of the body of the document - the main document editing surface.
/// </summary>
public partial class Body: ModelElement<DXW.Body>
{
  public Body(): base(){ }
  
  public Body(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Body(DXW.Body openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMW.SectionProperties? SectionProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
