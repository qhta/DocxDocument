namespace DocumentModel.Vml;


/// <summary>
///   Defines the Fill Class.
/// </summary>
public partial class Fill: ModelElement<DXV.Fill>
{
  public Fill(): base(){ }
  
  public Fill(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Fill(DXV.Fill openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Unique Identifier
  /// </summary>
  [DataMember]
  public String? Id
  {
    get => _Element?.Id;
    set => _ExistingElement.Id = value;
  }
  
  
  /// <summary>
  ///   Fill Toggle
  /// </summary>
  [DataMember]
  public Boolean? On
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   Primary Color
  /// </summary>
  [DataMember]
  public String? Color
  {
    get => _Element?.Color;
    set => _ExistingElement.Color = value;
  }
  
  
  /// <summary>
  ///   Primary Color Opacity
  /// </summary>
  [DataMember]
  public String? Opacity
  {
    get => _Element?.Opacity;
    set => _ExistingElement.Opacity = value;
  }
  
  
  /// <summary>
  ///   Secondary Color
  /// </summary>
  [DataMember]
  public String? Color2
  {
    get => _Element?.Color2;
    set => _ExistingElement.Color2 = value;
  }
  
  
  /// <summary>
  ///   Fill Image Source
  /// </summary>
  [DataMember]
  public String? Source
  {
    get => _Element?.Source;
    set => _ExistingElement.Source = value;
  }
  
  
  /// <summary>
  ///   Hyperlink Target
  /// </summary>
  [DataMember]
  public String? Href
  {
    get => _Element?.Href;
    set => _ExistingElement.Href = value;
  }
  
  
  /// <summary>
  ///   Alternate Image Reference Location
  /// </summary>
  [DataMember]
  public String? AlternateImageReference
  {
    get => _Element?.AlternateImageReference;
    set => _ExistingElement.AlternateImageReference = value;
  }
  
  
  /// <summary>
  ///   Fill Image Size
  /// </summary>
  [DataMember]
  public String? Size
  {
    get => _Element?.Size;
    set => _ExistingElement.Size = value;
  }
  
  
  /// <summary>
  ///   Fill Image Origin
  /// </summary>
  [DataMember]
  public String? Origin
  {
    get => _Element?.Origin;
    set => _ExistingElement.Origin = value;
  }
  
  
  /// <summary>
  ///   Fill Image Position
  /// </summary>
  [DataMember]
  public String? Position
  {
    get => _Element?.Position;
    set => _ExistingElement.Position = value;
  }
  
  
  /// <summary>
  ///   Intermediate Colors
  /// </summary>
  [DataMember]
  public String? Colors
  {
    get => _Element?.Colors;
    set => _ExistingElement.Colors = value;
  }
  
  
  /// <summary>
  ///   Gradient Angle
  /// </summary>
  [DataMember]
  public Decimal? Angle
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Decimal]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Decimal]");
  }
  
  
  /// <summary>
  ///   Align Image With Shape
  /// </summary>
  [DataMember]
  public Boolean? AlignShape
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   Gradient Center
  /// </summary>
  [DataMember]
  public String? Focus
  {
    get => _Element?.Focus;
    set => _ExistingElement.Focus = value;
  }
  
  
  /// <summary>
  ///   Radial Gradient Size
  /// </summary>
  [DataMember]
  public String? FocusSize
  {
    get => _Element?.FocusSize;
    set => _ExistingElement.FocusSize = value;
  }
  
  
  /// <summary>
  ///   Radial Gradient Center
  /// </summary>
  [DataMember]
  public String? FocusPosition
  {
    get => _Element?.FocusPosition;
    set => _ExistingElement.FocusPosition = value;
  }
  
  
  /// <summary>
  ///   Detect Mouse Click
  /// </summary>
  [DataMember]
  public Boolean? DetectMouseClick
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   Title
  /// </summary>
  [DataMember]
  public String? Title
  {
    get => _Element?.Title;
    set => _ExistingElement.Title = value;
  }
  
  
  /// <summary>
  ///   Secondary Color Opacity
  /// </summary>
  [DataMember]
  public String? Opacity2
  {
    get => _Element?.Opacity2;
    set => _ExistingElement.Opacity2 = value;
  }
  
  
  /// <summary>
  ///   Recolor Fill as Picture
  /// </summary>
  [DataMember]
  public Boolean? Recolor
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   Rotate Fill with Shape
  /// </summary>
  [DataMember]
  public Boolean? Rotate
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   Relationship to Part
  /// </summary>
  [DataMember]
  public String? RelationshipId
  {
    get => _Element?.RelationshipId;
    set => _ExistingElement.RelationshipId = value;
  }
  
  
  /// <summary>
  ///   FillExtendedProperties.
  /// </summary>
  [DataMember]
  public DMVML.FillExtendedProperties? FillExtendedProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlLeafElement");
  }
  
}
