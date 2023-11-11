namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the Trendline Class.
/// </summary>
public partial class Trendline: ModelElement<DXDC.Trendline>
{
  public Trendline(): base(){ }
  
  public Trendline(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Trendline(DXDC.Trendline openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Trendline Name.
  /// </summary>
  [DataMember]
  public DMDC.TrendlineName? TrendlineName
  {
    get
    {
      return _Element?.GetObject<DMDC.TrendlineName,DXDC.TrendlineName>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.TrendlineName,DXDC.TrendlineName>(value);
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
  ///   Trendline Type.
  /// </summary>
  [DataMember]
  public DMDC.TrendlineKind? TrendlineType
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.TrendlineValues, DMDC.TrendlineKind>(_ExistingElement.GetFirstChild<DXDC.TrendlineType>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.TrendlineType>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.TrendlineValues, DMDC.TrendlineKind>(itemElement, (DMDC.TrendlineKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDC.TrendlineType, DocumentFormat.OpenXml.Drawing.Charts.TrendlineValues, DMDC.TrendlineKind>((DMDC.TrendlineKind)value));
    }
  }
  
  
  /// <summary>
  ///   Polynomial Trendline Order.
  /// </summary>
  [DataMember]
  public Byte? PolynomialOrder
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DXDC.PolynomialOrder>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DXDC.PolynomialOrder,System.Byte>(_ExistingElement, value);
    }
  }
  
  
  /// <summary>
  ///   Period.
  /// </summary>
  [DataMember]
  public UInt32? Period
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DXDC.Period>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DXDC.Period,System.UInt32>(_ExistingElement, value);
    }
  }
  
  
  /// <summary>
  ///   Forward.
  /// </summary>
  [DataMember]
  public DMDC.Forward? Forward
  {
    get
    {
      return _Element?.GetObject<DMDC.Forward,DXDC.Forward>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.Forward,DXDC.Forward>(value);
    }
  }
  
  
  /// <summary>
  ///   Backward.
  /// </summary>
  [DataMember]
  public DMDC.Backward? Backward
  {
    get
    {
      return _Element?.GetObject<DMDC.Backward,DXDC.Backward>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.Backward,DXDC.Backward>(value);
    }
  }
  
  
  /// <summary>
  ///   Intercept.
  /// </summary>
  [DataMember]
  public DMDC.Intercept? Intercept
  {
    get
    {
      return _Element?.GetObject<DMDC.Intercept,DXDC.Intercept>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.Intercept,DXDC.Intercept>(value);
    }
  }
  
  
  /// <summary>
  ///   Display R Squared Value.
  /// </summary>
  [DataMember]
  public DMDC.DisplayRSquaredValue? DisplayRSquaredValue
  {
    get
    {
      return _Element?.GetObject<DMDC.DisplayRSquaredValue,DXDC.DisplayRSquaredValue>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.DisplayRSquaredValue,DXDC.DisplayRSquaredValue>(value);
    }
  }
  
  
  /// <summary>
  ///   Display Equation.
  /// </summary>
  [DataMember]
  public DMDC.DisplayEquation? DisplayEquation
  {
    get
    {
      return _Element?.GetObject<DMDC.DisplayEquation,DXDC.DisplayEquation>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.DisplayEquation,DXDC.DisplayEquation>(value);
    }
  }
  
  
  /// <summary>
  ///   Trendline Label.
  /// </summary>
  [DataMember]
  public DMDC.TrendlineLabel? TrendlineLabel
  {
    get
    {
      return _Element?.GetObject<DMDC.TrendlineLabel,DXDC.TrendlineLabel>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.TrendlineLabel,DXDC.TrendlineLabel>(value);
    }
  }
  
  
  /// <summary>
  ///   Chart Extensibility.
  /// </summary>
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
