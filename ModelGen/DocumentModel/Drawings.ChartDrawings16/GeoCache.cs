namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the GeoCache Class.
/// </summary>
public partial class GeoCache: ModelElement<DXO16DCD.GeoCache>
{
  public GeoCache(): base(){ }
  
  public GeoCache(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GeoCache(DXO16DCD.GeoCache openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   provider, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public String? Provider
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Provider);
    }
    set
    {
      _ExistingElement.Provider = StringValueConverter.CreateStringValue(value);
    }
  }
  
}
