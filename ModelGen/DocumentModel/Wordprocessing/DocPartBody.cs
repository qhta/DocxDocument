namespace DocumentModel.Wordprocessing;


/// <summary>
///   Contents of Glossary Document Entry.
/// </summary>
public partial class DocPartBody: ModelElement<DXW.DocPartBody>
{
  public DocPartBody(): base(){ }
  
  public DocPartBody(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DocPartBody(DXW.DocPartBody openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMW.SectionProperties? SectionProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
