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
  public DMDC.Bubble3D? Bubble3D
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.Bubble3D>();
      if (element != null)
        return Bubble3DConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.Bubble3D>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Bubble3DConverter.CreateOpenXmlElement<DXDC.Bubble3D>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      SimpleValueConverter.SetValue<DXDC.BubbleScale,System.UInt32>(openXmlElement, value);
    }
  }
  
  [DataMember]
  public DMDC.ShowNegativeBubbles? ShowNegativeBubbles
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.ShowNegativeBubbles>();
      if (element != null)
        return ShowNegativeBubblesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.ShowNegativeBubbles>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShowNegativeBubblesConverter.CreateOpenXmlElement<DXDC.ShowNegativeBubbles>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXDC.BubbleChartExtensionList>();
      if (element != null)
        return BubbleChartExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.BubbleChartExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BubbleChartExtensionListConverter.CreateOpenXmlElement<DXDC.BubbleChartExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
