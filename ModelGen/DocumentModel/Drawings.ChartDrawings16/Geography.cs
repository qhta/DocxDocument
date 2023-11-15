namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the Geography Class.
/// </summary>
public partial class Geography: ModelElement<DXO16DCD.Geography>
{
  public Geography(): base(){ }
  
  public Geography(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Geography(DXO16DCD.Geography openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   cultureLanguage, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public String? CultureLanguage
  {
    get => _Element?.CultureLanguage;
    set => _ExistingElement.CultureLanguage = value;
  }
  
  
  /// <summary>
  ///   cultureRegion, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public String? CultureRegion
  {
    get => _Element?.CultureRegion;
    set => _ExistingElement.CultureRegion = value;
  }
  
  
  /// <summary>
  ///   attribution, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public String? Attribution
  {
    get => _Element?.Attribution;
    set => _ExistingElement.Attribution = value;
  }
  
  
  /// <summary>
  ///   GeoCache.
  /// </summary>
  [DataMember]
  public DMDCD16.GeoCache? GeoCache
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
