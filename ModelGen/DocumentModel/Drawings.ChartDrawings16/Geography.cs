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
    get
    {
      return StringValueConverter.GetValue(_Element?.CultureLanguage);
    }
    set
    {
      _ExistingElement.CultureLanguage = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   cultureRegion, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public String? CultureRegion
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.CultureRegion);
    }
    set
    {
      _ExistingElement.CultureRegion = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   attribution, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public String? Attribution
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Attribution);
    }
    set
    {
      _ExistingElement.Attribution = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   GeoCache.
  /// </summary>
  [DataMember]
  public DMDCD16.GeoCache? GeoCache
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.GeoCache>();
      if (element != null)
        return GeoCacheConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.GeoCache>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GeoCacheConverter.CreateOpenXmlElement<DXO16DCD.GeoCache>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
