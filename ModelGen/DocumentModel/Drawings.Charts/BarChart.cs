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
      var element = _Element?.GetFirstChild<DXDC.VaryColors>();
      if (element != null)
        return VaryColorsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.VaryColors>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = VaryColorsConverter.CreateOpenXmlElement<DXDC.VaryColors>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC.DataLabels? DataLabels
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.DataLabels>();
      if (element != null)
        return DataLabelsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.DataLabels>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DataLabelsConverter.CreateOpenXmlElement<DXDC.DataLabels>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC.GapWidth? GapWidth
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.GapWidth>();
      if (element != null)
        return GapWidthConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.GapWidth>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GapWidthConverter.CreateOpenXmlElement<DXDC.GapWidth>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      SimpleValueConverter.SetValue<DXDC.Overlap,System.SByte>(openXmlElement, value);
    }
  }
  
  [DataMember]
  public DMDC.BarChartExtensionList? BarChartExtensionList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.BarChartExtensionList>();
      if (element != null)
        return BarChartExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.BarChartExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BarChartExtensionListConverter.CreateOpenXmlElement<DXDC.BarChartExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
