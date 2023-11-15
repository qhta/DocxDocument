namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a blur effect that is applied to the entire shape, including its fill. All color channels, including alpha, are affected.
/// </summary>
public partial class Blur: ModelElement<DXD.Blur>
{
  public Blur(): base(){ }
  
  public Blur(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Blur(DXD.Blur openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Specifies the radius of blur.
  /// </summary>
  [DataMember]
  public Int64? Radius
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
  }
  
  
  /// <summary>
  ///   Specifies whether the bounds of the object should be grown as a result of the blurring. True indicates the bounds are grown while false indicates that they are not.
  /// </summary>
  [DataMember]
  public Boolean? Grow
  {
    get => _Element?.Grow?.Value;
    set => _ExistingElement.Grow = value;
  }
  
}
