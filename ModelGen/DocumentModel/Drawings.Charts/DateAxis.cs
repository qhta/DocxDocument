namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Date Axis.
/// </summary>
public partial class DateAxis: ModelElement<DXDC.DateAxis>
{
  public DateAxis(): base(){ }
  
  public DateAxis(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DateAxis(DXDC.DateAxis openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Axis ID.
  /// </summary>
  [DataMember]
  public DMDC.AxisId? AxisId
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.AxisId>();
      if (element != null)
        return AxisIdConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.AxisId>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AxisIdConverter.CreateOpenXmlElement<DXDC.AxisId>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXDC.Scaling>();
      if (element != null)
        return ScalingConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.Scaling>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ScalingConverter.CreateOpenXmlElement<DXDC.Scaling>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXDC.Delete>();
      if (element != null)
        return DeleteConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.Delete>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DeleteConverter.CreateOpenXmlElement<DXDC.Delete>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXDC.MajorGridlines>();
      if (element != null)
        return MajorGridlinesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.MajorGridlines>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MajorGridlinesConverter.CreateOpenXmlElement<DXDC.MajorGridlines>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXDC.MinorGridlines>();
      if (element != null)
        return MinorGridlinesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.MinorGridlines>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MinorGridlinesConverter.CreateOpenXmlElement<DXDC.MinorGridlines>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXDC.Title>();
      if (element != null)
        return TitleConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.Title>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TitleConverter.CreateOpenXmlElement<DXDC.Title>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXDC.NumberingFormat>();
      if (element != null)
        return NumberingFormatConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.NumberingFormat>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NumberingFormatConverter.CreateOpenXmlElement<DXDC.NumberingFormat>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXDC.MajorTickMark>();
      if (element != null)
        return MajorTickMarkConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.MajorTickMark>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MajorTickMarkConverter.CreateOpenXmlElement<DXDC.MajorTickMark>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXDC.MinorTickMark>();
      if (element != null)
        return MinorTickMarkConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.MinorTickMark>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MinorTickMarkConverter.CreateOpenXmlElement<DXDC.MinorTickMark>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
  ///   TextProperties.
  /// </summary>
  [DataMember]
  public DMDC.TextProperties? TextProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.TextProperties>();
      if (element != null)
        return TextPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.TextProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TextPropertiesConverter.CreateOpenXmlElement<DXDC.TextProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXDC.CrossingAxis>();
      if (element != null)
        return CrossingAxisConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.CrossingAxis>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CrossingAxisConverter.CreateOpenXmlElement<DXDC.CrossingAxis>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXDC.CrossesAt>();
      if (element != null)
        return CrossesAtConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.CrossesAt>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CrossesAtConverter.CreateOpenXmlElement<DXDC.CrossesAt>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC.AutoLabeled? AutoLabeled
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.AutoLabeled>();
      if (element != null)
        return AutoLabeledConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.AutoLabeled>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AutoLabeledConverter.CreateOpenXmlElement<DXDC.AutoLabeled>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public UInt16? LabelOffset
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DXDC.LabelOffset>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DXDC.LabelOffset,System.UInt16>(openXmlElement, value);
    }
  }
  
  [DataMember]
  public DMDC.BaseTimeUnit? BaseTimeUnit
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.BaseTimeUnit>();
      if (element != null)
        return BaseTimeUnitConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.BaseTimeUnit>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BaseTimeUnitConverter.CreateOpenXmlElement<DXDC.BaseTimeUnit>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC.MajorUnit? MajorUnit
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.MajorUnit>();
      if (element != null)
        return MajorUnitConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.MajorUnit>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MajorUnitConverter.CreateOpenXmlElement<DXDC.MajorUnit>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC.MajorTimeUnit? MajorTimeUnit
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.MajorTimeUnit>();
      if (element != null)
        return MajorTimeUnitConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.MajorTimeUnit>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MajorTimeUnitConverter.CreateOpenXmlElement<DXDC.MajorTimeUnit>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC.MinorUnit? MinorUnit
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.MinorUnit>();
      if (element != null)
        return MinorUnitConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.MinorUnit>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MinorUnitConverter.CreateOpenXmlElement<DXDC.MinorUnit>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC.MinorTimeUnit? MinorTimeUnit
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.MinorTimeUnit>();
      if (element != null)
        return MinorTimeUnitConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.MinorTimeUnit>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MinorTimeUnitConverter.CreateOpenXmlElement<DXDC.MinorTimeUnit>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC.DateAxExtensionList? DateAxExtensionList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.DateAxExtensionList>();
      if (element != null)
        return DateAxExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.DateAxExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DateAxExtensionListConverter.CreateOpenXmlElement<DXDC.DateAxExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
