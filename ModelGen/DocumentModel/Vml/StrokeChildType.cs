namespace DocumentModel.Vml;


/// <summary>
///   Defines the StrokeChildType Class.
/// </summary>
public partial class StrokeChildType: ModelElement<DXVO.StrokeChildType>
{
  public StrokeChildType(): base(){ }
  
  public StrokeChildType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public StrokeChildType(DXVO.StrokeChildType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Stroke Toggle
  /// </summary>
  [DataMember]
  public Boolean? On
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   Stroke Weight
  /// </summary>
  [DataMember]
  public String? Weight
  {
    get => _Element?.Weight;
    set => _ExistingElement.Weight = value;
  }
  
  
  /// <summary>
  ///   Stroke Color
  /// </summary>
  [DataMember]
  public String? Color
  {
    get => _Element?.Color;
    set => _ExistingElement.Color = value;
  }
  
  
  /// <summary>
  ///   Stroke Alternate Pattern Color
  /// </summary>
  [DataMember]
  public String? Color2
  {
    get => _Element?.Color2;
    set => _ExistingElement.Color2 = value;
  }
  
  
  /// <summary>
  ///   Stroke Opacity
  /// </summary>
  [DataMember]
  public String? Opacity
  {
    get => _Element?.Opacity;
    set => _ExistingElement.Opacity = value;
  }
  
  
  /// <summary>
  ///   Miter Joint Limit
  /// </summary>
  [DataMember]
  public Decimal? MiterLimit
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Decimal]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Decimal]");
  }
  
  
  /// <summary>
  ///   Stroke Dash Pattern
  /// </summary>
  [DataMember]
  public String? DashStyle
  {
    get => _Element?.DashStyle;
    set => _ExistingElement.DashStyle = value;
  }
  
  
  /// <summary>
  ///   Inset Border From Path
  /// </summary>
  [DataMember]
  public Boolean? InsetPen
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   Stroke Image Location
  /// </summary>
  [DataMember]
  public String? Source
  {
    get => _Element?.Source;
    set => _ExistingElement.Source = value;
  }
  
  
  /// <summary>
  ///   Stroke Image Size
  /// </summary>
  [DataMember]
  public String? ImageSize
  {
    get => _Element?.ImageSize;
    set => _ExistingElement.ImageSize = value;
  }
  
  
  /// <summary>
  ///   Stoke Image Alignment
  /// </summary>
  [DataMember]
  public Boolean? ImageAlignShape
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   Original Image Reference
  /// </summary>
  [DataMember]
  public String? Href
  {
    get => _Element?.Href;
    set => _ExistingElement.Href = value;
  }
  
  
  /// <summary>
  ///   Alternate Image Reference
  /// </summary>
  [DataMember]
  public String? AlternateImageReference
  {
    get => _Element?.AlternateImageReference;
    set => _ExistingElement.AlternateImageReference = value;
  }
  
  
  /// <summary>
  ///   Stroke Title
  /// </summary>
  [DataMember]
  public String? Title
  {
    get => _Element?.Title;
    set => _ExistingElement.Title = value;
  }
  
  
  /// <summary>
  ///   Force Dashed Outline
  /// </summary>
  [DataMember]
  public Boolean? ForceDash
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
}
