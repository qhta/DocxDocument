namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the PivotSource Class.
/// </summary>
public partial class PivotSource: ModelElement<DXDC.PivotSource>
{
  public PivotSource(): base(){ }
  
  public PivotSource(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PivotSource(DXDC.PivotSource openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Pivot Name.
  /// </summary>
  [DataMember]
  public DMDC.PivotTableName? PivotTableName
  {
    get
    {
      return _Element?.GetObject<DMDC.PivotTableName,DXDC.PivotTableName>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.PivotTableName,DXDC.PivotTableName>(value);
    }
  }
  
  
  /// <summary>
  ///   Format ID.
  /// </summary>
  [DataMember]
  public DMDC.FormatId? FormatId
  {
    get
    {
      return _Element?.GetObject<DMDC.FormatId,DXDC.FormatId>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.FormatId,DXDC.FormatId>(value);
    }
  }
  
  
  /// <summary>
  ///   Chart Extensibility.
  /// </summary>
  [DataMember]
  public DMDC.ExtensionList? ExtensionList
  {
    get
    {
      return _Element?.GetObject<DMDC.ExtensionList,DXDC.ExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.ExtensionList,DXDC.ExtensionList>(value);
    }
  }
  
}
