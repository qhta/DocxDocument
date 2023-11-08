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
  public DMDC.GapWidth? GapWidth
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.GapWidth>();
      if (element != null)
        return GapWidthConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.GapWidth>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GapWidthConverter.CreateOpenXmlElement<DXDC.GapWidth>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXDC.SplitPosition>();
      if (element != null)
        return SplitPositionConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.SplitPosition>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SplitPositionConverter.CreateOpenXmlElement<DXDC.SplitPosition>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC.CustomSplit? CustomSplit
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.CustomSplit>();
      if (element != null)
        return CustomSplitConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.CustomSplit>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CustomSplitConverter.CreateOpenXmlElement<DXDC.CustomSplit>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      SimpleValueConverter.SetValue<DXDC.SecondPieSize,System.UInt16>(openXmlElement, value);
    }
  }
  
  [DataMember]
  public DMDC.ExtensionList? ExtensionList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.ExtensionList>();
      if (element != null)
        return ExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DXDC.ExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
