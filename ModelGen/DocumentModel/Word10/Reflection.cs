namespace DocumentModel.Word10;


/// <summary>
///   This element specifies the reflection effect.
/// </summary>
public partial class Reflection: ModelElement<DXO10W.Reflection>
{
  public Reflection(): base(){ }
  
  public Reflection(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Reflection(DXO10W.Reflection openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   blurRad, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int64? BlurRadius
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
  }
  
  
  /// <summary>
  ///   stA, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? StartingOpacity
  {
    get => _Element?.StartingOpacity?.Value;
    set => _ExistingElement.StartingOpacity = value;
  }
  
  
  /// <summary>
  ///   stPos, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? StartPosition
  {
    get => _Element?.StartPosition?.Value;
    set => _ExistingElement.StartPosition = value;
  }
  
  
  /// <summary>
  ///   endA, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? EndingOpacity
  {
    get => _Element?.EndingOpacity?.Value;
    set => _ExistingElement.EndingOpacity = value;
  }
  
  
  /// <summary>
  ///   endPos, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? EndPosition
  {
    get => _Element?.EndPosition?.Value;
    set => _ExistingElement.EndPosition = value;
  }
  
  
  /// <summary>
  ///   dist, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int64? DistanceFromText
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
  }
  
  
  /// <summary>
  ///   dir, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? DirectionAngle
  {
    get => _Element?.DirectionAngle?.Value;
    set => _ExistingElement.DirectionAngle = value;
  }
  
  
  /// <summary>
  ///   fadeDir, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? FadeDirection
  {
    get => _Element?.FadeDirection?.Value;
    set => _ExistingElement.FadeDirection = value;
  }
  
  
  /// <summary>
  ///   sx, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? HorizontalScalingFactor
  {
    get => _Element?.HorizontalScalingFactor?.Value;
    set => _ExistingElement.HorizontalScalingFactor = value;
  }
  
  
  /// <summary>
  ///   sy, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? VerticalScalingFactor
  {
    get => _Element?.VerticalScalingFactor?.Value;
    set => _ExistingElement.VerticalScalingFactor = value;
  }
  
  
  /// <summary>
  ///   kx, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? HorizontalSkewAngle
  {
    get => _Element?.HorizontalSkewAngle?.Value;
    set => _ExistingElement.HorizontalSkewAngle = value;
  }
  
  
  /// <summary>
  ///   ky, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? VerticalSkewAngle
  {
    get => _Element?.VerticalSkewAngle?.Value;
    set => _ExistingElement.VerticalSkewAngle = value;
  }
  
}
