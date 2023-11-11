namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Value Axis.
/// </summary>
public partial class ValueAxis: ModelElement<DXDC.ValueAxis>
{
  public ValueAxis(): base(){ }
  
  public ValueAxis(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ValueAxis(DXDC.ValueAxis openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Axis ID.
  /// </summary>
  [DataMember]
  public DMDC.AxisId? AxisId
  {
    get
    {
      return _Element?.GetObject<DMDC.AxisId,DXDC.AxisId>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.AxisId,DXDC.AxisId>(value);
    }
  }
  
  
  /// <summary>
  ///   Scaling.
  /// </summary>
  [DataMember]
  public DMDC.Scaling? Scaling
  {
    get
    {
      return _Element?.GetObject<DMDC.Scaling,DXDC.Scaling>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.Scaling,DXDC.Scaling>(value);
    }
  }
  
  
  /// <summary>
  ///   Delete.
  /// </summary>
  [DataMember]
  public DMDC.Delete? Delete
  {
    get
    {
      return _Element?.GetObject<DMDC.Delete,DXDC.Delete>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.Delete,DXDC.Delete>(value);
    }
  }
  
  
  /// <summary>
  ///   Axis Position.
  /// </summary>
  [DataMember]
  public DMDC.AxisPositionKind? AxisPosition
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.AxisPositionValues, DMDC.AxisPositionKind>(_ExistingElement.GetFirstChild<DXDC.AxisPosition>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.AxisPosition>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.AxisPositionValues, DMDC.AxisPositionKind>(itemElement, (DMDC.AxisPositionKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDC.AxisPosition, DocumentFormat.OpenXml.Drawing.Charts.AxisPositionValues, DMDC.AxisPositionKind>((DMDC.AxisPositionKind)value));
    }
  }
  
  
  /// <summary>
  ///   Major Gridlines.
  /// </summary>
  [DataMember]
  public DMDC.MajorGridlines? MajorGridlines
  {
    get
    {
      return _Element?.GetObject<DMDC.MajorGridlines,DXDC.MajorGridlines>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.MajorGridlines,DXDC.MajorGridlines>(value);
    }
  }
  
  
  /// <summary>
  ///   Minor Gridlines.
  /// </summary>
  [DataMember]
  public DMDC.MinorGridlines? MinorGridlines
  {
    get
    {
      return _Element?.GetObject<DMDC.MinorGridlines,DXDC.MinorGridlines>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.MinorGridlines,DXDC.MinorGridlines>(value);
    }
  }
  
  
  /// <summary>
  ///   Title.
  /// </summary>
  [DataMember]
  public DMDC.Title? Title
  {
    get
    {
      return _Element?.GetObject<DMDC.Title,DXDC.Title>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.Title,DXDC.Title>(value);
    }
  }
  
  
  /// <summary>
  ///   Number Format.
  /// </summary>
  [DataMember]
  public DMDC.NumberingFormat? NumberingFormat
  {
    get
    {
      return _Element?.GetObject<DMDC.NumberingFormat,DXDC.NumberingFormat>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.NumberingFormat,DXDC.NumberingFormat>(value);
    }
  }
  
  
  /// <summary>
  ///   Major Tick Mark.
  /// </summary>
  [DataMember]
  public DMDC.MajorTickMark? MajorTickMark
  {
    get
    {
      return _Element?.GetObject<DMDC.MajorTickMark,DXDC.MajorTickMark>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.MajorTickMark,DXDC.MajorTickMark>(value);
    }
  }
  
  
  /// <summary>
  ///   Minor Tick Mark.
  /// </summary>
  [DataMember]
  public DMDC.MinorTickMark? MinorTickMark
  {
    get
    {
      return _Element?.GetObject<DMDC.MinorTickMark,DXDC.MinorTickMark>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.MinorTickMark,DXDC.MinorTickMark>(value);
    }
  }
  
  
  /// <summary>
  ///   Tick Label Position.
  /// </summary>
  [DataMember]
  public DMDC.TickLabelPositionKind? TickLabelPosition
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.TickLabelPositionValues, DMDC.TickLabelPositionKind>(_ExistingElement.GetFirstChild<DXDC.TickLabelPosition>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.TickLabelPosition>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.TickLabelPositionValues, DMDC.TickLabelPositionKind>(itemElement, (DMDC.TickLabelPositionKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDC.TickLabelPosition, DocumentFormat.OpenXml.Drawing.Charts.TickLabelPositionValues, DMDC.TickLabelPositionKind>((DMDC.TickLabelPositionKind)value));
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
  ///   TextProperties.
  /// </summary>
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
  
  
  /// <summary>
  ///   Crossing Axis ID.
  /// </summary>
  [DataMember]
  public DMDC.CrossingAxis? CrossingAxis
  {
    get
    {
      return _Element?.GetObject<DMDC.CrossingAxis,DXDC.CrossingAxis>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.CrossingAxis,DXDC.CrossingAxis>(value);
    }
  }
  
  [DataMember]
  public DMDC.CrossesKind? Crosses
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.CrossesValues, DMDC.CrossesKind>(_ExistingElement.GetFirstChild<DXDC.Crosses>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.Crosses>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.CrossesValues, DMDC.CrossesKind>(itemElement, (DMDC.CrossesKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDC.Crosses, DocumentFormat.OpenXml.Drawing.Charts.CrossesValues, DMDC.CrossesKind>((DMDC.CrossesKind)value));
    }
  }
  
  [DataMember]
  public DMDC.CrossesAt? CrossesAt
  {
    get
    {
      return _Element?.GetObject<DMDC.CrossesAt,DXDC.CrossesAt>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.CrossesAt,DXDC.CrossesAt>(value);
    }
  }
  
  [DataMember]
  public DMDC.CrossBetweenKind? CrossBetween
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.CrossBetweenValues, DMDC.CrossBetweenKind>(_ExistingElement.GetFirstChild<DXDC.CrossBetween>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.CrossBetween>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.CrossBetweenValues, DMDC.CrossBetweenKind>(itemElement, (DMDC.CrossBetweenKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXDC.CrossBetween, DocumentFormat.OpenXml.Drawing.Charts.CrossBetweenValues, DMDC.CrossBetweenKind>((DMDC.CrossBetweenKind)value));
    }
  }
  
  [DataMember]
  public DMDC.MajorUnit? MajorUnit
  {
    get
    {
      return _Element?.GetObject<DMDC.MajorUnit,DXDC.MajorUnit>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.MajorUnit,DXDC.MajorUnit>(value);
    }
  }
  
  [DataMember]
  public DMDC.MinorUnit? MinorUnit
  {
    get
    {
      return _Element?.GetObject<DMDC.MinorUnit,DXDC.MinorUnit>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.MinorUnit,DXDC.MinorUnit>(value);
    }
  }
  
  [DataMember]
  public DMDC.DisplayUnits? DisplayUnits
  {
    get
    {
      return _Element?.GetObject<DMDC.DisplayUnits,DXDC.DisplayUnits>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.DisplayUnits,DXDC.DisplayUnits>(value);
    }
  }
  
  [DataMember]
  public DMDC.ValAxExtensionList? ValAxExtensionList
  {
    get
    {
      return _Element?.GetObject<DMDC.ValAxExtensionList,DXDC.ValAxExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.ValAxExtensionList,DXDC.ValAxExtensionList>(value);
    }
  }
  
}
