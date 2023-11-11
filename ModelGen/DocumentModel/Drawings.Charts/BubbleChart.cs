namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Bubble Charts.
/// </summary>
public partial class BubbleChart: ModelElement<DXDC.BubbleChart>
{
  public BubbleChart(): base(){ }
  
  public BubbleChart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BubbleChart(DXDC.BubbleChart openXmlElement): base(openXmlElement) { }
  
  
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
  public DMDC.Bubble3D? Bubble3D
  {
    get
    {
      return _Element?.GetObject<DMDC.Bubble3D,DXDC.Bubble3D>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.Bubble3D,DXDC.Bubble3D>(value);
    }
  }
  
  [DataMember]
  public UInt32? BubbleScale
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DXDC.BubbleScale>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DXDC.BubbleScale,System.UInt32>(_ExistingElement, value);
    }
  }
  
  [DataMember]
  public DMDC.ShowNegativeBubbles? ShowNegativeBubbles
  {
    get
    {
      return _Element?.GetObject<DMDC.ShowNegativeBubbles,DXDC.ShowNegativeBubbles>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.ShowNegativeBubbles,DXDC.ShowNegativeBubbles>(value);
    }
  }
  
  [DataMember]
  public DMDC.SizeRepresentsKind? SizeRepresents
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.SizeRepresentsValues, DMDC.SizeRepresentsKind>(_ExistingElement.GetFirstChild<DXDC.SizeRepresents>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.SizeRepresents>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.SizeRepresentsValues, DMDC.SizeRepresentsKind>(itemElement, (DMDC.SizeRepresentsKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDC.SizeRepresents, DocumentFormat.OpenXml.Drawing.Charts.SizeRepresentsValues, DMDC.SizeRepresentsKind>((DMDC.SizeRepresentsKind)value));
    }
  }
  
  [DataMember]
  public DMDC.BubbleChartExtensionList? BubbleChartExtensionList
  {
    get
    {
      return _Element?.GetObject<DMDC.BubbleChartExtensionList,DXDC.BubbleChartExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.BubbleChartExtensionList,DXDC.BubbleChartExtensionList>(value);
    }
  }
  
}
