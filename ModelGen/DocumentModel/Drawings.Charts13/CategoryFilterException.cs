namespace DocumentModel.Drawings.Charts13;


/// <summary>
///   Defines the CategoryFilterException Class.
/// </summary>
public partial class CategoryFilterException: ModelElement<DXO13DC.CategoryFilterException>
{
  public CategoryFilterException(): base(){ }
  
  public CategoryFilterException(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CategoryFilterException(DXO13DC.CategoryFilterException openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   SequenceOfReferences.
  /// </summary>
  [DataMember]
  public DMDC13.SequenceOfReferences? SequenceOfReferences
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
  }
  
  
  /// <summary>
  ///   ShapeProperties.
  /// </summary>
  [DataMember]
  public DMDC13.ShapeProperties? ShapeProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   Explosion.
  /// </summary>
  [DataMember]
  public UInt32? Explosion
  {
    get => _Element?.GetIntVal<UInt32, DXO13DC.Explosion>();
    set => _ExistingElement.SetIntVal<UInt32, DXO13DC.Explosion>(value);
  }
  
  
  /// <summary>
  ///   InvertIfNegativeBoolean.
  /// </summary>
  [DataMember]
  public DMDC13.InvertIfNegativeBoolean? InvertIfNegativeBoolean
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Office2013.Drawing.Chart.BooleanType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Office2013.Drawing.Chart.BooleanType");
  }
  
  
  /// <summary>
  ///   Bubble3D.
  /// </summary>
  [DataMember]
  public DMDC13.Bubble3D? Bubble3D
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Office2013.Drawing.Chart.BooleanType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Office2013.Drawing.Chart.BooleanType");
  }
  
  
  /// <summary>
  ///   Marker.
  /// </summary>
  [DataMember]
  public DMDC13.Marker? Marker
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
  
  /// <summary>
  ///   DataLabel.
  /// </summary>
  [DataMember]
  public DMDC13.DataLabel? DataLabel
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
