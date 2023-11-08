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
  public DMDC.GapDepth? GapDepth
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.GapDepth>();
      if (element != null)
        return GapDepthConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.GapDepth>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GapDepthConverter.CreateOpenXmlElement<DXDC.GapDepth>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXDC.Bar3DChartExtensionList>();
      if (element != null)
        return Bar3DChartExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.Bar3DChartExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Bar3DChartExtensionListConverter.CreateOpenXmlElement<DXDC.Bar3DChartExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
