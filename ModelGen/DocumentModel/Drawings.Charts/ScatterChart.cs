namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Scatter Charts.
/// </summary>
public partial class ScatterChart: ModelElement<DXDC.ScatterChart>
{
  public ScatterChart(): base(){ }
  
  public ScatterChart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ScatterChart(DXDC.ScatterChart openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   ScatterStyle.
  /// </summary>
  [DataMember]
  public DMDC.ScatterStyleKind? ScatterStyle
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.ScatterStyleValues, DMDC.ScatterStyleKind>(_ExistingElement.GetFirstChild<DXDC.ScatterStyle>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.ScatterStyle>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ScatterStyleValues, DMDC.ScatterStyleKind>(itemElement, (DMDC.ScatterStyleKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDC.ScatterStyle, DocumentFormat.OpenXml.Drawing.Charts.ScatterStyleValues, DMDC.ScatterStyleKind>((DMDC.ScatterStyleKind)value));
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
  public DMDC.ScatterChartExtensionList? ScatterChartExtensionList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.ScatterChartExtensionList>();
      if (element != null)
        return ScatterChartExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.ScatterChartExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ScatterChartExtensionListConverter.CreateOpenXmlElement<DXDC.ScatterChartExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
