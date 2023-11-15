namespace DocumentModel.Word10;


/// <summary>
///   This element specifies the outline style to be applied to text. By default, text does not have outline.
/// </summary>
public partial class TextOutlineEffect: ModelElement<DXO10W.TextOutlineEffect>
{
  public TextOutlineEffect(): base(){ }
  
  public TextOutlineEffect(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TextOutlineEffect(DXO10W.TextOutlineEffect openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   w, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? LineWidth
  {
    get => _Element?.LineWidth?.Value;
    set => _ExistingElement.LineWidth = value;
  }
  
  [DataMember]
  public DMW10.NoFillEmpty? NoFillEmpty
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Office2010.Word.EmptyType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Office2010.Word.EmptyType");
  }
  
  [DataMember]
  public DMW10.SolidColorFillProperties? SolidColorFillProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  [DataMember]
  public DMW10.GradientFillProperties? GradientFillProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  [DataMember]
  public DMW10.PresetLineDashKind? PresetLineDashProperties
  {
    get => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertyGetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertySetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  [DataMember]
  public DMW10.RoundEmpty? RoundEmpty
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Office2010.Word.EmptyType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Office2010.Word.EmptyType");
  }
  
  [DataMember]
  public DMW10.BevelEmpty? BevelEmpty
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Office2010.Word.EmptyType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Office2010.Word.EmptyType");
  }
  
  [DataMember]
  public DMW10.LineJoinMiterProperties? LineJoinMiterProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
}
