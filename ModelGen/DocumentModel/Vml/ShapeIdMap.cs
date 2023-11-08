namespace DocumentModel.Vml;


/// <summary>
///   Shape ID Map.
/// </summary>
public partial class ShapeIdMap: ModelElement<DXVO.ShapeIdMap>
{
  public ShapeIdMap(): base(){ }
  
  public ShapeIdMap(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ShapeIdMap(DXVO.ShapeIdMap openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Shape IDs
  /// </summary>
  [DataMember]
  public String? Data
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Data);
    }
    set
    {
      _ExistingElement.Data = StringValueConverter.CreateStringValue(value);
    }
  }
  
}
