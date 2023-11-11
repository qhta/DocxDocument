namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Bar Charts.
/// </summary>
public partial class BarChart: ModelElement<DXDC.BarChart>
{
  public BarChart(): base(){ }
  
  public BarChart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BarChart(DXDC.BarChart openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Bar Direction.
  /// </summary>
  [DataMember]
  public DMDC.BarDirectionKind? BarDirection
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.BarDirectionValues, DMDC.BarDirectionKind>(_ExistingElement.GetFirstChild<DXDC.BarDirection>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.BarDirection>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.BarDirectionValues, DMDC.BarDirectionKind>(itemElement, (DMDC.BarDirectionKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDC.BarDirection, DocumentFormat.OpenXml.Drawing.Charts.BarDirectionValues, DMDC.BarDirectionKind>((DMDC.BarDirectionKind)value));
    }
  }
  
  
  /// <summary>
  ///   Bar Grouping.
  /// </summary>
  [DataMember]
  public DMDC.BarGroupingKind? BarGrouping
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.BarGroupingValues, DMDC.BarGroupingKind>(_ExistingElement.GetFirstChild<DXDC.BarGrouping>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.BarGrouping>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.BarGroupingValues, DMDC.BarGroupingKind>(itemElement, (DMDC.BarGroupingKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDC.BarGrouping, DocumentFormat.OpenXml.Drawing.Charts.BarGroupingValues, DMDC.BarGroupingKind>((DMDC.BarGroupingKind)value));
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
  public DMDC.GapWidth? GapWidth
  {
    get
    {
      return _Element?.GetObject<DMDC.GapWidth,DXDC.GapWidth>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.GapWidth,DXDC.GapWidth>(value);
    }
  }
  
  [DataMember]
  public SByte? Overlap
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DXDC.Overlap>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DXDC.Overlap,System.SByte>(_ExistingElement, value);
    }
  }
  
  [DataMember]
  public DMDC.BarChartExtensionList? BarChartExtensionList
  {
    get
    {
      return _Element?.GetObject<DMDC.BarChartExtensionList,DXDC.BarChartExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.BarChartExtensionList,DXDC.BarChartExtensionList>(value);
    }
  }
  
}
