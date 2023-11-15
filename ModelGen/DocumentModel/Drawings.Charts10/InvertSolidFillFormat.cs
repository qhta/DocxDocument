namespace DocumentModel.Drawings.Charts10;


/// <summary>
///   Defines the InvertSolidFillFormat Class.
/// </summary>
public partial class InvertSolidFillFormat: ModelElement<DXO10DC.InvertSolidFillFormat>
{
  public InvertSolidFillFormat(): base(){ }
  
  public InvertSolidFillFormat(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public InvertSolidFillFormat(DXO10DC.InvertSolidFillFormat openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   ShapeProperties.
  /// </summary>
  [DataMember]
  public DMDC10.ShapeProperties? ShapeProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
