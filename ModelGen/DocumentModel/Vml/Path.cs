namespace DocumentModel.Vml;


/// <summary>
///   Defines the Path Class.
/// </summary>
public partial class Path: ModelElement<DXV.Path>
{
  public Path(): base(){ }
  
  public Path(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Path(DXV.Path openXmlElement): base(openXmlElement) { }
  
  
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
  ///   Path Definition
  /// </summary>
  [DataMember]
  public String? Value
  {
    get => _Element?.Value;
    set => _ExistingElement.Value = value;
  }
  
  
  /// <summary>
  ///   Limo Stretch Point
  /// </summary>
  [DataMember]
  public String? Limo
  {
    get => _Element?.Limo;
    set => _ExistingElement.Limo = value;
  }
  
  
  /// <summary>
  ///   Text Box Bounding Box
  /// </summary>
  [DataMember]
  public String? TextboxRectangle
  {
    get => _Element?.TextboxRectangle;
    set => _ExistingElement.TextboxRectangle = value;
  }
  
  
  /// <summary>
  ///   Shape Fill Toggle
  /// </summary>
  [DataMember]
  public Boolean? AllowFill
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   Stroke Toggle
  /// </summary>
  [DataMember]
  public Boolean? AllowStroke
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   Shadow Toggle
  /// </summary>
  [DataMember]
  public Boolean? AllowShading
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   Arrowhead Display Toggle
  /// </summary>
  [DataMember]
  public Boolean? ShowArrowhead
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   Gradient Shape Toggle
  /// </summary>
  [DataMember]
  public Boolean? AllowGradientShape
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   Text Path Toggle
  /// </summary>
  [DataMember]
  public Boolean? AllowTextPath
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   Inset Stroke From Path Flag
  /// </summary>
  [DataMember]
  public Boolean? AllowInsetPen
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
  
  /// <summary>
  ///   Connection Points
  /// </summary>
  [DataMember]
  public String? ConnectionPoints
  {
    get => _Element?.ConnectionPoints;
    set => _ExistingElement.ConnectionPoints = value;
  }
  
  
  /// <summary>
  ///   Connection Point Connect Angles
  /// </summary>
  [DataMember]
  public String? ConnectAngles
  {
    get => _Element?.ConnectAngles;
    set => _ExistingElement.ConnectAngles = value;
  }
  
  
  /// <summary>
  ///   Extrusion Toggle
  /// </summary>
  [DataMember]
  public Boolean? AllowExtrusion
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.TrueFalseValue");
  }
  
}
