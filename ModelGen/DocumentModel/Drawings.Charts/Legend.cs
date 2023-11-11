namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Legend data and formatting.
/// </summary>
public partial class Legend: ModelElement<DXDC.Legend>
{
  public Legend(): base(){ }
  
  public Legend(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Legend(DXDC.Legend openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Legend Position.
  /// </summary>
  [DataMember]
  public DMDC.LegendPositionKind? LegendPosition
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.LegendPositionValues, DMDC.LegendPositionKind>(_ExistingElement.GetFirstChild<DXDC.LegendPosition>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.LegendPosition>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.LegendPositionValues, DMDC.LegendPositionKind>(itemElement, (DMDC.LegendPositionKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDC.LegendPosition, DocumentFormat.OpenXml.Drawing.Charts.LegendPositionValues, DMDC.LegendPositionKind>((DMDC.LegendPositionKind)value));
    }
  }
  
  [DataMember]
  public DMDC.Layout? Layout
  {
    get
    {
      return _Element?.GetObject<DMDC.Layout,DXDC.Layout>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.Layout,DXDC.Layout>(value);
    }
  }
  
  [DataMember]
  public DMDC.Overlay? Overlay
  {
    get
    {
      return _Element?.GetObject<DMDC.Overlay,DXDC.Overlay>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.Overlay,DXDC.Overlay>(value);
    }
  }
  
  [DataMember]
  public DMDC.ChartShapeProperties? ChartShapeProperties
  {
    get
    {
      return _Element?.GetObject<DMDC.ChartShapeProperties,DXDC.ChartShapeProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.ChartShapeProperties,DXDC.ChartShapeProperties>(value);
    }
  }
  
  [DataMember]
  public DMDC.TextProperties? TextProperties
  {
    get
    {
      return _Element?.GetObject<DMDC.TextProperties,DXDC.TextProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.TextProperties,DXDC.TextProperties>(value);
    }
  }
  
  [DataMember]
  public DMDC.ExtensionList? ExtensionList
  {
    get
    {
      return _Element?.GetObject<DMDC.ExtensionList,DXDC.ExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.ExtensionList,DXDC.ExtensionList>(value);
    }
  }
  
}
