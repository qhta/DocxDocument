namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the RichTextBody Class.
/// </summary>
public partial class RichTextBody: ModelElement<DXO16DCD.RichTextBody>
{
  public RichTextBody(): base(){ }
  
  public RichTextBody(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public RichTextBody(DXO16DCD.RichTextBody openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMD.BodyProperties? BodyProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  [DataMember]
  public DMD.ListStyle? ListStyle
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
