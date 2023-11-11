namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Bar Chart Series.
/// </summary>
public partial class BarChartSeries: ModelElement<DXDC.BarChartSeries>
{
  public BarChartSeries(): base(){ }
  
  public BarChartSeries(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BarChartSeries(DXDC.BarChartSeries openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Index.
  /// </summary>
  [DataMember]
  public DMDC.Index? Index
  {
    get
    {
      return _Element?.GetObject<DMDC.Index,DXDC.Index>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.Index,DXDC.Index>(value);
    }
  }
  
  
  /// <summary>
  ///   Order.
  /// </summary>
  [DataMember]
  public DMDC.Order? Order
  {
    get
    {
      return _Element?.GetObject<DMDC.Order,DXDC.Order>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.Order,DXDC.Order>(value);
    }
  }
  
  
  /// <summary>
  ///   Series Text.
  /// </summary>
  [DataMember]
  public DMDC.SeriesText? SeriesText
  {
    get
    {
      return _Element?.GetObject<DMDC.SeriesText,DXDC.SeriesText>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.SeriesText,DXDC.SeriesText>(value);
    }
  }
  
  
  /// <summary>
  ///   ChartShapeProperties.
  /// </summary>
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
  
  
  /// <summary>
  ///   InvertIfNegative.
  /// </summary>
  [DataMember]
  public DMDC.InvertIfNegative? InvertIfNegative
  {
    get
    {
      return _Element?.GetObject<DMDC.InvertIfNegative,DXDC.InvertIfNegative>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.InvertIfNegative,DXDC.InvertIfNegative>(value);
    }
  }
  
  
  /// <summary>
  ///   PictureOptions.
  /// </summary>
  [DataMember]
  public DMDC.PictureOptions? PictureOptions
  {
    get
    {
      return _Element?.GetObject<DMDC.PictureOptions,DXDC.PictureOptions>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.PictureOptions,DXDC.PictureOptions>(value);
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
  public DMDC.ErrorBars? ErrorBars
  {
    get
    {
      return _Element?.GetObject<DMDC.ErrorBars,DXDC.ErrorBars>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.ErrorBars,DXDC.ErrorBars>(value);
    }
  }
  
  [DataMember]
  public DMDC.CategoryAxisData? CategoryAxisData
  {
    get
    {
      return _Element?.GetObject<DMDC.CategoryAxisData,DXDC.CategoryAxisData>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.CategoryAxisData,DXDC.CategoryAxisData>(value);
    }
  }
  
  [DataMember]
  public DMDC.Values? Values
  {
    get
    {
      return _Element?.GetObject<DMDC.Values,DXDC.Values>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.Values,DXDC.Values>(value);
    }
  }
  
  [DataMember]
  public DMDC.ShapeKind? Shape
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.ShapeValues, DMDC.ShapeKind>(_ExistingElement.GetFirstChild<DXDC.Shape>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.Shape>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ShapeValues, DMDC.ShapeKind>(itemElement, (DMDC.ShapeKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDC.Shape, DocumentFormat.OpenXml.Drawing.Charts.ShapeValues, DMDC.ShapeKind>((DMDC.ShapeKind)value));
    }
  }
  
  [DataMember]
  public DMDC.BarSerExtensionList? BarSerExtensionList
  {
    get
    {
      return _Element?.GetObject<DMDC.BarSerExtensionList,DXDC.BarSerExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.BarSerExtensionList,DXDC.BarSerExtensionList>(value);
    }
  }
  
}
