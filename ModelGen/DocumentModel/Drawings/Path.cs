namespace DocumentModel.Drawings;


/// <summary>
///   This element defines that a gradient fill follows a path vs. a linear line.
/// </summary>
public partial class Path: ModelElement<DXD.Path>
{
  public Path(): base(){ }
  
  public Path(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Path(DXD.Path openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Path Width
  /// </summary>
  [DataMember]
  public Int64? Width
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
  }
  
  
  /// <summary>
  ///   Path Height
  /// </summary>
  [DataMember]
  public Int64? Height
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.Int64]");
  }
  
  
  /// <summary>
  ///   Path Stroke
  /// </summary>
  [DataMember]
  public Boolean? Stroke
  {
    get => _Element?.Stroke?.Value;
    set => _ExistingElement.Stroke = value;
  }
  
  
  /// <summary>
  ///   3D Extrusion Allowed
  /// </summary>
  [DataMember]
  public Boolean? ExtrusionOk
  {
    get => _Element?.ExtrusionOk?.Value;
    set => _ExistingElement.ExtrusionOk = value;
  }
  
}
