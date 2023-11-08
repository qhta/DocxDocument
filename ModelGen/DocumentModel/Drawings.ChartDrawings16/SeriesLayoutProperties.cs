namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the SeriesLayoutProperties Class.
/// </summary>
public partial class SeriesLayoutProperties: ModelElement<DXO16DCD.SeriesLayoutProperties>
{
  public SeriesLayoutProperties(): base(){ }
  
  public SeriesLayoutProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SeriesLayoutProperties(DXO16DCD.SeriesLayoutProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   ParentLabelLayout.
  /// </summary>
  [DataMember]
  public DMDCD16.ParentLabelLayout? ParentLabelLayout
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.ParentLabelLayout>();
      if (element != null)
        return ParentLabelLayoutConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.ParentLabelLayout>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ParentLabelLayoutConverter.CreateOpenXmlElement<DXO16DCD.ParentLabelLayout>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   RegionLabelLayout.
  /// </summary>
  [DataMember]
  public DMDCD16.RegionLabelLayoutEnum? RegionLabelLayout
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.RegionLabelLayoutEnum, DMDCD16.RegionLabelLayoutEnum>(_ExistingElement.GetFirstChild<DXO16DCD.RegionLabelLayout>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.RegionLabelLayout>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.RegionLabelLayoutEnum, DMDCD16.RegionLabelLayoutEnum>(itemElement, (DMDCD16.RegionLabelLayoutEnum)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXO16DCD.RegionLabelLayout, DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.RegionLabelLayoutEnum, DMDCD16.RegionLabelLayoutEnum>((DMDCD16.RegionLabelLayoutEnum)value));
    }
  }
  
  
  /// <summary>
  ///   SeriesElementVisibilities.
  /// </summary>
  [DataMember]
  public DMDCD16.SeriesElementVisibilities? SeriesElementVisibilities
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.SeriesElementVisibilities>();
      if (element != null)
        return SeriesElementVisibilitiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.SeriesElementVisibilities>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SeriesElementVisibilitiesConverter.CreateOpenXmlElement<DXO16DCD.SeriesElementVisibilities>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDCD16.Aggregation? Aggregation
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.Aggregation>();
      if (element != null)
        return AggregationConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.Aggregation>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AggregationConverter.CreateOpenXmlElement<DXO16DCD.Aggregation>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDCD16.Binning? Binning
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.Binning>();
      if (element != null)
        return BinningConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.Binning>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BinningConverter.CreateOpenXmlElement<DXO16DCD.Binning>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDCD16.Geography? Geography
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.Geography>();
      if (element != null)
        return GeographyConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.Geography>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GeographyConverter.CreateOpenXmlElement<DXO16DCD.Geography>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDCD16.Statistics? Statistics
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.Statistics>();
      if (element != null)
        return StatisticsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.Statistics>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StatisticsConverter.CreateOpenXmlElement<DXO16DCD.Statistics>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDCD16.Subtotals? Subtotals
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.Subtotals>();
      if (element != null)
        return SubtotalsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.Subtotals>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SubtotalsConverter.CreateOpenXmlElement<DXO16DCD.Subtotals>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDCD16.ExtensionList? ExtensionList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.ExtensionList>();
      if (element != null)
        return ExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DXO16DCD.ExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
