namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Radar Charts.
/// </summary>
public partial class RadarChart: ModelElement<DXDC.RadarChart>
{
  public RadarChart(): base(){ }
  
  public RadarChart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public RadarChart(DXDC.RadarChart openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   RadarStyle.
  /// </summary>
  [DataMember]
  public DMDC.RadarStyleKind? RadarStyle
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.RadarStyleValues, DMDC.RadarStyleKind>(_ExistingElement.GetFirstChild<DXDC.RadarStyle>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.RadarStyle>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.RadarStyleValues, DMDC.RadarStyleKind>(itemElement, (DMDC.RadarStyleKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDC.RadarStyle, DocumentFormat.OpenXml.Drawing.Charts.RadarStyleValues, DMDC.RadarStyleKind>((DMDC.RadarStyleKind)value));
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
  public DMDC.RadarChartExtensionList? RadarChartExtensionList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.RadarChartExtensionList>();
      if (element != null)
        return RadarChartExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.RadarChartExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RadarChartExtensionListConverter.CreateOpenXmlElement<DXDC.RadarChartExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
