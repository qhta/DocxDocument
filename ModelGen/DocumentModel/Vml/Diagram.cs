namespace DocumentModel.Vml;


/// <summary>
///   VML Diagram.
/// </summary>
public partial class Diagram: ModelElement<DXVO.Diagram>
{
  public Diagram(): base(){ }
  
  public Diagram(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Diagram(DXVO.Diagram openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Diagram Style Options
  /// </summary>
  [DataMember]
  public Int64? Style
  {
    get => _Element?.Style?.Value;
    set => _ExistingElement.Style = value;
  }
  
  
  /// <summary>
  ///   Diagram Automatic Format
  /// </summary>
  [DataMember]
  public Boolean? AutoFormat
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   Diagram Reverse Direction
  /// </summary>
  [DataMember]
  public Boolean? Reverse
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   Diagram Automatic Layout
  /// </summary>
  [DataMember]
  public Boolean? AutoLayout
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   Diagram Layout X Scale
  /// </summary>
  [DataMember]
  public Int64? ScaleX
  {
    get => _Element?.ScaleX?.Value;
    set => _ExistingElement.ScaleX = value;
  }
  
  
  /// <summary>
  ///   Diagram Layout Y Scale
  /// </summary>
  [DataMember]
  public Int64? ScaleY
  {
    get => _Element?.ScaleY?.Value;
    set => _ExistingElement.ScaleY = value;
  }
  
  
  /// <summary>
  ///   Diagram Font Size
  /// </summary>
  [DataMember]
  public Int64? FontSize
  {
    get => _Element?.FontSize?.Value;
    set => _ExistingElement.FontSize = value;
  }
  
  
  /// <summary>
  ///   Diagram Layout Extents
  /// </summary>
  [DataMember]
  public String? ConstrainBounds
  {
    get => _Element?.ConstrainBounds;
    set => _ExistingElement.ConstrainBounds = value;
  }
  
  
  /// <summary>
  ///   Diagram Base Font Size
  /// </summary>
  [DataMember]
  public Int64? BaseTextScale
  {
    get => _Element?.BaseTextScale?.Value;
    set => _ExistingElement.BaseTextScale = value;
  }
  
  
  /// <summary>
  ///   Diagram Relationship Table.
  /// </summary>
  [DataMember]
  public DMVML.RelationTable? RelationTable
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
