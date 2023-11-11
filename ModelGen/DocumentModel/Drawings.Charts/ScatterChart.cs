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
  public DMDC.ScatterChartExtensionList? ScatterChartExtensionList
  {
    get
    {
      return _Element?.GetObject<DMDC.ScatterChartExtensionList,DXDC.ScatterChartExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.ScatterChartExtensionList,DXDC.ScatterChartExtensionList>(value);
    }
  }
  
}
