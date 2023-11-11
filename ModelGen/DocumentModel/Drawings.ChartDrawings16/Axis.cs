namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the Axis Class.
/// </summary>
public partial class Axis: ModelElement<DXO16DCD.Axis>
{
  public Axis(): base(){ }
  
  public Axis(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Axis(DXO16DCD.Axis openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   id, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public UInt32? Id
  {
    get
    {
      return _Element?.Id?.Value;
    }
    set
    {
      _ExistingElement.Id = value;
    }
  }
  
  
  /// <summary>
  ///   hidden, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public Boolean? Hidden
  {
    get
    {
      return _Element?.Hidden?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Hidden = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.Hidden = null;
    }
  }
  
  [DataMember]
  public DMDCD16.CategoryAxisScaling? CategoryAxisScaling
  {
    get
    {
      return _Element?.GetObject<DMDCD16.CategoryAxisScaling,DXO16DCD.CategoryAxisScaling>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.CategoryAxisScaling,DXO16DCD.CategoryAxisScaling>(value);
    }
  }
  
  [DataMember]
  public DMDCD16.ValueAxisScaling? ValueAxisScaling
  {
    get
    {
      return _Element?.GetObject<DMDCD16.ValueAxisScaling,DXO16DCD.ValueAxisScaling>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.ValueAxisScaling,DXO16DCD.ValueAxisScaling>(value);
    }
  }
  
  [DataMember]
  public DMDCD16.AxisTitle? AxisTitle
  {
    get
    {
      return _Element?.GetObject<DMDCD16.AxisTitle,DXO16DCD.AxisTitle>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.AxisTitle,DXO16DCD.AxisTitle>(value);
    }
  }
  
  [DataMember]
  public DMDCD16.AxisUnits? AxisUnits
  {
    get
    {
      return _Element?.GetObject<DMDCD16.AxisUnits,DXO16DCD.AxisUnits>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.AxisUnits,DXO16DCD.AxisUnits>(value);
    }
  }
  
  [DataMember]
  public DMDCD16.MajorGridlinesGridlines? MajorGridlinesGridlines
  {
    get
    {
      return _Element?.GetObject<DMDCD16.MajorGridlinesGridlines,DXO16DCD.MajorGridlinesGridlines>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.MajorGridlinesGridlines,DXO16DCD.MajorGridlinesGridlines>(value);
    }
  }
  
  [DataMember]
  public DMDCD16.MinorGridlinesGridlines? MinorGridlinesGridlines
  {
    get
    {
      return _Element?.GetObject<DMDCD16.MinorGridlinesGridlines,DXO16DCD.MinorGridlinesGridlines>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.MinorGridlinesGridlines,DXO16DCD.MinorGridlinesGridlines>(value);
    }
  }
  
  [DataMember]
  public DMDCD16.MajorTickMarksTickMarks? MajorTickMarksTickMarks
  {
    get
    {
      return _Element?.GetObject<DMDCD16.MajorTickMarksTickMarks,DXO16DCD.MajorTickMarksTickMarks>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.MajorTickMarksTickMarks,DXO16DCD.MajorTickMarksTickMarks>(value);
    }
  }
  
  [DataMember]
  public DMDCD16.MinorTickMarksTickMarks? MinorTickMarksTickMarks
  {
    get
    {
      return _Element?.GetObject<DMDCD16.MinorTickMarksTickMarks,DXO16DCD.MinorTickMarksTickMarks>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.MinorTickMarksTickMarks,DXO16DCD.MinorTickMarksTickMarks>(value);
    }
  }
  
  [DataMember]
  public DMDCD16.TickLabels? TickLabels
  {
    get
    {
      return _Element?.GetObject<DMDCD16.TickLabels,DXO16DCD.TickLabels>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.TickLabels,DXO16DCD.TickLabels>(value);
    }
  }
  
  [DataMember]
  public DMDCD16.NumberFormat? NumberFormat
  {
    get
    {
      return _Element?.GetObject<DMDCD16.NumberFormat,DXO16DCD.NumberFormat>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.NumberFormat,DXO16DCD.NumberFormat>(value);
    }
  }
  
  [DataMember]
  public DMDCD16.ShapeProperties? ShapeProperties
  {
    get
    {
      return _Element?.GetObject<DMDCD16.ShapeProperties,DXO16DCD.ShapeProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.ShapeProperties,DXO16DCD.ShapeProperties>(value);
    }
  }
  
  [DataMember]
  public DMDCD16.TxPrTextBody? TxPrTextBody
  {
    get
    {
      return _Element?.GetObject<DMDCD16.TxPrTextBody,DXO16DCD.TxPrTextBody>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.TxPrTextBody,DXO16DCD.TxPrTextBody>(value);
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
