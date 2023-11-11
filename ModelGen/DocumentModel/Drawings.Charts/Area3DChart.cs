namespace DocumentModel.Drawings.Charts;


/// <summary>
///   3D Area Charts.
/// </summary>
public partial class Area3DChart: ModelElement<DXDC.Area3DChart>
{
  public Area3DChart(): base(){ }
  
  public Area3DChart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Area3DChart(DXDC.Area3DChart openXmlElement): base(openXmlElement) { }
  
  
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
  public DMDC.Area3DChartExtensionList? Area3DChartExtensionList
  {
    get
    {
      return _Element?.GetObject<DMDC.Area3DChartExtensionList,DXDC.Area3DChartExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.Area3DChartExtensionList,DXDC.Area3DChartExtensionList>(value);
    }
  }
  
}
