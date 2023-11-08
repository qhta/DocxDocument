namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the GeoEntity Class.
/// </summary>
public partial class GeoEntity: ModelElement<DXO16DCD.GeoEntity>
{
  public GeoEntity(): base(){ }
  
  public GeoEntity(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GeoEntity(DXO16DCD.GeoEntity openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   entityName, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public String? EntityName
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.EntityName);
    }
    set
    {
      _ExistingElement.EntityName = StringValueConverter.CreateStringValue(value);
    }
  }
  
}
