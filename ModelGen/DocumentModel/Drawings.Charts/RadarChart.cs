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
  public DMDC.RadarChartExtensionList? RadarChartExtensionList
  {
    get
    {
      return _Element?.GetObject<DMDC.RadarChartExtensionList,DXDC.RadarChartExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.RadarChartExtensionList,DXDC.RadarChartExtensionList>(value);
    }
  }
  
}
