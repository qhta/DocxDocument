namespace DocumentModel.Wordprocessing;


/// <summary>
///   Nested Frameset Definition.
/// </summary>
public partial class Frameset: ModelElement<DXW.Frameset>
{
  public Frameset(): base(){ }
  
  public Frameset(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Frameset(DXW.Frameset openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Nested Frameset Size.
  /// </summary>
  [DataMember]
  public DMW.FrameSize? FrameSize
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.StringType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.StringType");
  }
  
  
  /// <summary>
  ///   Frameset Splitter Properties.
  /// </summary>
  [DataMember]
  public DMW.FramesetSplitbar? FramesetSplitbar
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Frameset Layout.
  /// </summary>
  [DataMember]
  public DMW.FrameLayoutKind? FrameLayout
  {
    get => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertyGetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertySetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
}
