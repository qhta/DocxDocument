namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines SdtElement - the base class for the sdt elements.
/// </summary>
public partial class SdtElement: ModelElement<DXW.SdtElement>
{
  public SdtElement(): base(){ }
  
  public SdtElement(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SdtElement(DXW.SdtElement openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Gets or sets the SdtProperties.
  /// </summary>
  [DataMember]
  public DMW.SdtProperties? SdtProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Gets or sets the SdtEndCharProperties.
  /// </summary>
  [DataMember]
  public DMW.SdtEndCharProperties? SdtEndCharProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
