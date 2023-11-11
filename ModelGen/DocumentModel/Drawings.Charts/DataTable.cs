namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Data Table.
/// </summary>
public partial class DataTable: ModelElement<DXDC.DataTable>
{
  public DataTable(): base(){ }
  
  public DataTable(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DataTable(DXDC.DataTable openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Show Horizontal Border.
  /// </summary>
  [DataMember]
  public DMDC.ShowHorizontalBorder? ShowHorizontalBorder
  {
    get
    {
      return _Element?.GetObject<DMDC.ShowHorizontalBorder,DXDC.ShowHorizontalBorder>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.ShowHorizontalBorder,DXDC.ShowHorizontalBorder>(value);
    }
  }
  
  
  /// <summary>
  ///   Show Vertical Border.
  /// </summary>
  [DataMember]
  public DMDC.ShowVerticalBorder? ShowVerticalBorder
  {
    get
    {
      return _Element?.GetObject<DMDC.ShowVerticalBorder,DXDC.ShowVerticalBorder>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.ShowVerticalBorder,DXDC.ShowVerticalBorder>(value);
    }
  }
  
  
  /// <summary>
  ///   Show Outline Border.
  /// </summary>
  [DataMember]
  public DMDC.ShowOutlineBorder? ShowOutlineBorder
  {
    get
    {
      return _Element?.GetObject<DMDC.ShowOutlineBorder,DXDC.ShowOutlineBorder>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.ShowOutlineBorder,DXDC.ShowOutlineBorder>(value);
    }
  }
  
  
  /// <summary>
  ///   Show Legend Keys.
  /// </summary>
  [DataMember]
  public DMDC.ShowKeys? ShowKeys
  {
    get
    {
      return _Element?.GetObject<DMDC.ShowKeys,DXDC.ShowKeys>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.ShowKeys,DXDC.ShowKeys>(value);
    }
  }
  
  
  /// <summary>
  ///   ChartShapeProperties.
  /// </summary>
  [DataMember]
  public DMDC.ChartShapeProperties? ChartShapeProperties
  {
    get
    {
      return _Element?.GetObject<DMDC.ChartShapeProperties,DXDC.ChartShapeProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.ChartShapeProperties,DXDC.ChartShapeProperties>(value);
    }
  }
  
  
  /// <summary>
  ///   Text Properties.
  /// </summary>
  [DataMember]
  public DMDC.TextProperties? TextProperties
  {
    get
    {
      return _Element?.GetObject<DMDC.TextProperties,DXDC.TextProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.TextProperties,DXDC.TextProperties>(value);
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
