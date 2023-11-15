namespace DocumentModel.Word10;


/// <summary>
///   This element specifies the fill for text. By default, this element is absent. When this element is absent, the color of text is determined by the color element.
/// </summary>
public partial class FillTextEffect: ModelElement<DXO10W.FillTextEffect>
{
  public FillTextEffect(): base(){ }
  
  public FillTextEffect(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FillTextEffect(DXO10W.FillTextEffect openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   NoFillEmpty.
  /// </summary>
  [DataMember]
  public DMW10.NoFillEmpty? NoFillEmpty
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Office2010.Word.EmptyType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Office2010.Word.EmptyType");
  }
  
  
  /// <summary>
  ///   SolidColorFillProperties.
  /// </summary>
  [DataMember]
  public DMW10.SolidColorFillProperties? SolidColorFillProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   GradientFillProperties.
  /// </summary>
  [DataMember]
  public DMW10.GradientFillProperties? GradientFillProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
