namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Area Charts.
/// </summary>
public partial class AreaChart: ModelElement<DXDC.AreaChart>
{
  public AreaChart(): base(){ }
  
  public AreaChart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public AreaChart(DXDC.AreaChart openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Grouping.
  /// </summary>
  [DataMember]
  public DMDC.GroupingKind? Grouping
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.GroupingValues, DMDC.GroupingKind>(_ExistingElement.GetFirstChild<DXDC.Grouping>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.Grouping>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.GroupingValues, DMDC.GroupingKind>(itemElement, (DMDC.GroupingKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDC.Grouping, DocumentFormat.OpenXml.Drawing.Charts.GroupingValues, DMDC.GroupingKind>((DMDC.GroupingKind)value));
    }
  }
  
  
  /// <summary>
  ///   VaryColors.
  /// </summary>
  [DataMember]
  public DMDC.VaryColors? VaryColors
  {
    get
    {
      return _Element?.GetObject<DMDC.VaryColors,DXDC.VaryColors>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.VaryColors,DXDC.VaryColors>(value);
    }
  }
  
  [DataMember]
  public DMDC.DataLabels? DataLabels
  {
    get
    {
      return _Element?.GetObject<DMDC.DataLabels,DXDC.DataLabels>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.DataLabels,DXDC.DataLabels>(value);
    }
  }
  
  [DataMember]
  public DMDC.DropLines? DropLines
  {
    get
    {
      return _Element?.GetObject<DMDC.DropLines,DXDC.DropLines>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.DropLines,DXDC.DropLines>(value);
    }
  }
  
  [DataMember]
  public DMDC.AreaChartExtensionList? AreaChartExtensionList
  {
    get
    {
      return _Element?.GetObject<DMDC.AreaChartExtensionList,DXDC.AreaChartExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.AreaChartExtensionList,DXDC.AreaChartExtensionList>(value);
    }
  }
  
}
