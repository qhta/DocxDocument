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
  public DMDC.DropLines? DropLines
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.DropLines>();
      if (element != null)
        return DropLinesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.DropLines>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DropLinesConverter.CreateOpenXmlElement<DXDC.DropLines>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC.AreaChartExtensionList? AreaChartExtensionList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.AreaChartExtensionList>();
      if (element != null)
        return AreaChartExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.AreaChartExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AreaChartExtensionListConverter.CreateOpenXmlElement<DXDC.AreaChartExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
