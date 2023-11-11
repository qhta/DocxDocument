namespace DocumentModel.Drawings.Charts;


/// <summary>
///   3D Line Charts.
/// </summary>
public partial class Line3DChart: ModelElement<DXDC.Line3DChart>
{
  public Line3DChart(): base(){ }
  
  public Line3DChart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Line3DChart(DXDC.Line3DChart openXmlElement): base(openXmlElement) { }
  
  
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
  public DMDC.Line3DChartExtensionList? Line3DChartExtensionList
  {
    get
    {
      return _Element?.GetObject<DMDC.Line3DChartExtensionList,DXDC.Line3DChartExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.Line3DChartExtensionList,DXDC.Line3DChartExtensionList>(value);
    }
  }
  
}
