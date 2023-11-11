namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the StringDataType Class.
/// </summary>
public partial class StringDataType: ModelElement<DXDC.StringDataType>
{
  public StringDataType(): base(){ }
  
  public StringDataType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public StringDataType(DXDC.StringDataType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   PointCount.
  /// </summary>
  [DataMember]
  public DMDC.PointCount? PointCount
  {
    get
    {
      return _Element?.GetObject<DMDC.PointCount,DXDC.PointCount>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.PointCount,DXDC.PointCount>(value);
    }
  }
  
}
