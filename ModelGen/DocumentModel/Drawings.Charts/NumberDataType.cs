namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the NumberDataType Class.
/// </summary>
public partial class NumberDataType: ModelElement<DXDC.NumberDataType>
{
  public NumberDataType(): base(){ }
  
  public NumberDataType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NumberDataType(DXDC.NumberDataType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Format Code.
  /// </summary>
  [DataMember]
  public DMDC.FormatCode? FormatCode
  {
    get
    {
      return _Element?.GetObject<DMDC.FormatCode,DXDC.FormatCode>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.FormatCode,DXDC.FormatCode>(value);
    }
  }
  
  
  /// <summary>
  ///   Point Count.
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
