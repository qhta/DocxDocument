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
      var element = _Element?.GetFirstChild<DXDC.TrendlineName>();
      if (element != null)
        return TrendlineNameConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.TrendlineName>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TrendlineNameConverter.CreateOpenXmlElement<DXDC.TrendlineName>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXDC.ChartShapeProperties>();
      if (element != null)
        return ChartShapePropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.ChartShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ChartShapePropertiesConverter.CreateOpenXmlElement<DXDC.ChartShapeProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      SimpleValueConverter.SetValue<DXDC.PolynomialOrder,System.Byte>(openXmlElement, value);
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
      SimpleValueConverter.SetValue<DXDC.Period,System.UInt32>(openXmlElement, value);
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
      var element = _Element?.GetFirstChild<DXDC.Forward>();
      if (element != null)
        return ForwardConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.Forward>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ForwardConverter.CreateOpenXmlElement<DXDC.Forward>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXDC.Backward>();
      if (element != null)
        return BackwardConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.Backward>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BackwardConverter.CreateOpenXmlElement<DXDC.Backward>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXDC.Intercept>();
      if (element != null)
        return InterceptConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.Intercept>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = InterceptConverter.CreateOpenXmlElement<DXDC.Intercept>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXDC.DisplayRSquaredValue>();
      if (element != null)
        return DisplayRSquaredValueConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.DisplayRSquaredValue>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DisplayRSquaredValueConverter.CreateOpenXmlElement<DXDC.DisplayRSquaredValue>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXDC.DisplayEquation>();
      if (element != null)
        return DisplayEquationConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.DisplayEquation>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DisplayEquationConverter.CreateOpenXmlElement<DXDC.DisplayEquation>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXDC.TrendlineLabel>();
      if (element != null)
        return TrendlineLabelConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.TrendlineLabel>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TrendlineLabelConverter.CreateOpenXmlElement<DXDC.TrendlineLabel>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
