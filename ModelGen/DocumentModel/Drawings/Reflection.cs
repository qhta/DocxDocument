namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a reflection effect.
/// </summary>
public partial class Reflection: ModelElement<DXD.Reflection>
{
  public Reflection(): base(){ }
  
  public Reflection(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Reflection(DXD.Reflection openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Specifies the blur radius.
  /// </summary>
  [DataMember]
  public Int64? BlurRadius
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
  }
  
  
  /// <summary>
  ///   starting reflection opacity.
  /// </summary>
  [DataMember]
  public Int32? StartOpacity
  {
    get => _Element?.StartOpacity?.Value;
    set => _ExistingElement.StartOpacity = value;
  }
  
  
  /// <summary>
  ///   Specifies the start position (along the alpha gradient ramp) of the start alpha value.
  /// </summary>
  [DataMember]
  public Int32? StartPosition
  {
    get => _Element?.StartPosition?.Value;
    set => _ExistingElement.StartPosition = value;
  }
  
  
  /// <summary>
  ///   Specifies the ending reflection opacity.
  /// </summary>
  [DataMember]
  public Int32? EndAlpha
  {
    get => _Element?.EndAlpha?.Value;
    set => _ExistingElement.EndAlpha = value;
  }
  
  
  /// <summary>
  ///   Specifies the end position (along the alpha gradient ramp) of the end alpha value.
  /// </summary>
  [DataMember]
  public Int32? EndPosition
  {
    get => _Element?.EndPosition?.Value;
    set => _ExistingElement.EndPosition = value;
  }
  
  
  /// <summary>
  ///   Specifies how far to distance the shadow.
  /// </summary>
  [DataMember]
  public Int64? Distance
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
  }
  
  
  /// <summary>
  ///   Specifies the direction of the alpha gradient ramp relative to the shape itself.
  /// </summary>
  [DataMember]
  public Int32? Direction
  {
    get => _Element?.Direction?.Value;
    set => _ExistingElement.Direction = value;
  }
  
  
  /// <summary>
  ///   Specifies the direction to offset the reflection.
  /// </summary>
  [DataMember]
  public Int32? FadeDirection
  {
    get => _Element?.FadeDirection?.Value;
    set => _ExistingElement.FadeDirection = value;
  }
  
  
  /// <summary>
  ///   Specifies the horizontal scaling factor.
  /// </summary>
  [DataMember]
  public Int32? HorizontalRatio
  {
    get => _Element?.HorizontalRatio?.Value;
    set => _ExistingElement.HorizontalRatio = value;
  }
  
  
  /// <summary>
  ///   Specifies the vertical scaling factor.
  /// </summary>
  [DataMember]
  public Int32? VerticalRatio
  {
    get => _Element?.VerticalRatio?.Value;
    set => _ExistingElement.VerticalRatio = value;
  }
  
  
  /// <summary>
  ///   Specifies the horizontal skew angle.
  /// </summary>
  [DataMember]
  public Int32? HorizontalSkew
  {
    get => _Element?.HorizontalSkew?.Value;
    set => _ExistingElement.HorizontalSkew = value;
  }
  
  
  /// <summary>
  ///   Specifies the vertical skew angle.
  /// </summary>
  [DataMember]
  public Int32? VerticalSkew
  {
    get => _Element?.VerticalSkew?.Value;
    set => _ExistingElement.VerticalSkew = value;
  }
  
  
  /// <summary>
  ///   Rotate With Shape
  /// </summary>
  [DataMember]
  public Boolean? RotateWithShape
  {
    get => _Element?.RotateWithShape?.Value;
    set => _ExistingElement.RotateWithShape = value;
  }
  
}
