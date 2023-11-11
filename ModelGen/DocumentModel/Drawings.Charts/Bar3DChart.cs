namespace DocumentModel.Drawings.Charts;


/// <summary>
///   3D Bar Charts.
/// </summary>
public partial class Bar3DChart: ModelElement<DXDC.Bar3DChart>
{
  public Bar3DChart(): base(){ }
  
  public Bar3DChart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Bar3DChart(DXDC.Bar3DChart openXmlElement): base(openXmlElement) { }
  
  
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
  public DMDC.GapDepth? GapDepth
  {
    get
    {
      return _Element?.GetObject<DMDC.GapDepth,DXDC.GapDepth>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.GapDepth,DXDC.GapDepth>(value);
    }
  }
  
  [DataMember]
  public DMDC.ShapeKind? Shape
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.ShapeValues, DMDC.ShapeKind>(_ExistingElement.GetFirstChild<DXDC.Shape>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.Shape>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ShapeValues, DMDC.ShapeKind>(itemElement, (DMDC.ShapeKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDC.Shape, DocumentFormat.OpenXml.Drawing.Charts.ShapeValues, DMDC.ShapeKind>((DMDC.ShapeKind)value));
    }
  }
  
  [DataMember]
  public DMDC.Bar3DChartExtensionList? Bar3DChartExtensionList
  {
    get
    {
      return _Element?.GetObject<DMDC.Bar3DChartExtensionList,DXDC.Bar3DChartExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.Bar3DChartExtensionList,DXDC.Bar3DChartExtensionList>(value);
    }
  }
  
}
