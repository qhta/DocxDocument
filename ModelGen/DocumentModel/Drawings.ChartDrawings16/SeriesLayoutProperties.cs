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
      return _Element?.GetObject<DMDCD16.ParentLabelLayout,DXO16DCD.ParentLabelLayout>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.ParentLabelLayout,DXO16DCD.ParentLabelLayout>(value);
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
      return _Element?.GetObject<DMDCD16.SeriesElementVisibilities,DXO16DCD.SeriesElementVisibilities>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.SeriesElementVisibilities,DXO16DCD.SeriesElementVisibilities>(value);
    }
  }
  
  [DataMember]
  public DMDCD16.Aggregation? Aggregation
  {
    get
    {
      return _Element?.GetObject<DMDCD16.Aggregation,DXO16DCD.Aggregation>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.Aggregation,DXO16DCD.Aggregation>(value);
    }
  }
  
  [DataMember]
  public DMDCD16.Binning? Binning
  {
    get
    {
      return _Element?.GetObject<DMDCD16.Binning,DXO16DCD.Binning>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.Binning,DXO16DCD.Binning>(value);
    }
  }
  
  [DataMember]
  public DMDCD16.Geography? Geography
  {
    get
    {
      return _Element?.GetObject<DMDCD16.Geography,DXO16DCD.Geography>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.Geography,DXO16DCD.Geography>(value);
    }
  }
  
  [DataMember]
  public DMDCD16.Statistics? Statistics
  {
    get
    {
      return _Element?.GetObject<DMDCD16.Statistics,DXO16DCD.Statistics>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.Statistics,DXO16DCD.Statistics>(value);
    }
  }
  
  [DataMember]
  public DMDCD16.Subtotals? Subtotals
  {
    get
    {
      return _Element?.GetObject<DMDCD16.Subtotals,DXO16DCD.Subtotals>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.Subtotals,DXO16DCD.Subtotals>(value);
    }
  }
  
  [DataMember]
  public DMDCD16.ExtensionList? ExtensionList
  {
    get
    {
      return _Element?.GetObject<DMDCD16.ExtensionList,DXO16DCD.ExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.ExtensionList,DXO16DCD.ExtensionList>(value);
    }
  }
  
}
