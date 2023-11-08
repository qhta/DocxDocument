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
      var element = _Element?.GetFirstChild<DXDC.PivotTableName>();
      if (element != null)
        return PivotTableNameConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.PivotTableName>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PivotTableNameConverter.CreateOpenXmlElement<DXDC.PivotTableName>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXDC.FormatId>();
      if (element != null)
        return FormatIdConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.FormatId>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FormatIdConverter.CreateOpenXmlElement<DXDC.FormatId>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXDC.ExtensionList>();
      if (element != null)
        return ExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DXDC.ExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
