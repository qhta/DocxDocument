namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Pie of Pie or Bar of Pie Charts.
/// </summary>
public partial class OfPieChart: ModelElement<DXDC.OfPieChart>
{
  public OfPieChart(): base(){ }
  
  public OfPieChart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public OfPieChart(DXDC.OfPieChart openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Pie of Pie or Bar of Pie Type.
  /// </summary>
  [DataMember]
  public DMDC.OfPieKind? OfPieType
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.OfPieValues, DMDC.OfPieKind>(_ExistingElement.GetFirstChild<DXDC.OfPieType>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.OfPieType>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.OfPieValues, DMDC.OfPieKind>(itemElement, (DMDC.OfPieKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDC.OfPieType, DocumentFormat.OpenXml.Drawing.Charts.OfPieValues, DMDC.OfPieKind>((DMDC.OfPieKind)value));
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
  public DMDC.GapWidth? GapWidth
  {
    get
    {
      return _Element?.GetObject<DMDC.GapWidth,DXDC.GapWidth>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.GapWidth,DXDC.GapWidth>(value);
    }
  }
  
  [DataMember]
  public DMDC.SplitKind? SplitType
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.SplitValues, DMDC.SplitKind>(_ExistingElement.GetFirstChild<DXDC.SplitType>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.SplitType>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.SplitValues, DMDC.SplitKind>(itemElement, (DMDC.SplitKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDC.SplitType, DocumentFormat.OpenXml.Drawing.Charts.SplitValues, DMDC.SplitKind>((DMDC.SplitKind)value));
    }
  }
  
  [DataMember]
  public DMDC.SplitPosition? SplitPosition
  {
    get
    {
      return _Element?.GetObject<DMDC.SplitPosition,DXDC.SplitPosition>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.SplitPosition,DXDC.SplitPosition>(value);
    }
  }
  
  [DataMember]
  public DMDC.CustomSplit? CustomSplit
  {
    get
    {
      return _Element?.GetObject<DMDC.CustomSplit,DXDC.CustomSplit>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.CustomSplit,DXDC.CustomSplit>(value);
    }
  }
  
  [DataMember]
  public UInt16? SecondPieSize
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DXDC.SecondPieSize>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DXDC.SecondPieSize,System.UInt16>(_ExistingElement, value);
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
