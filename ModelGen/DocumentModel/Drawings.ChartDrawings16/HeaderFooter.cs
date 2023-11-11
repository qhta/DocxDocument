namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the HeaderFooter Class.
/// </summary>
public partial class HeaderFooter: ModelElement<DXO16DCD.HeaderFooter>
{
  public HeaderFooter(): base(){ }
  
  public HeaderFooter(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public HeaderFooter(DXO16DCD.HeaderFooter openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   alignWithMargins, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public Boolean? AlignWithMargins
  {
    get
    {
      return _Element?.AlignWithMargins?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.AlignWithMargins = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.AlignWithMargins = null;
    }
  }
  
  
  /// <summary>
  ///   differentOddEven, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public Boolean? DifferentOddEven
  {
    get
    {
      return _Element?.DifferentOddEven?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.DifferentOddEven = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.DifferentOddEven = null;
    }
  }
  
  
  /// <summary>
  ///   differentFirst, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public Boolean? DifferentFirst
  {
    get
    {
      return _Element?.DifferentFirst?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.DifferentFirst = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.DifferentFirst = null;
    }
  }
  
  
  /// <summary>
  ///   OddHeaderXsdstring.
  /// </summary>
  [DataMember]
  public DMDCD16.OddHeaderXsdstring? OddHeaderXsdstring
  {
    get
    {
      return _Element?.GetObject<DMDCD16.OddHeaderXsdstring,DXO16DCD.OddHeaderXsdstring>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.OddHeaderXsdstring,DXO16DCD.OddHeaderXsdstring>(value);
    }
  }
  
  
  /// <summary>
  ///   OddFooterXsdstring.
  /// </summary>
  [DataMember]
  public DMDCD16.OddFooterXsdstring? OddFooterXsdstring
  {
    get
    {
      return _Element?.GetObject<DMDCD16.OddFooterXsdstring,DXO16DCD.OddFooterXsdstring>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.OddFooterXsdstring,DXO16DCD.OddFooterXsdstring>(value);
    }
  }
  
  
  /// <summary>
  ///   EvenHeaderXsdstring.
  /// </summary>
  [DataMember]
  public DMDCD16.EvenHeaderXsdstring? EvenHeaderXsdstring
  {
    get
    {
      return _Element?.GetObject<DMDCD16.EvenHeaderXsdstring,DXO16DCD.EvenHeaderXsdstring>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.EvenHeaderXsdstring,DXO16DCD.EvenHeaderXsdstring>(value);
    }
  }
  
  
  /// <summary>
  ///   EvenFooterXsdstring.
  /// </summary>
  [DataMember]
  public DMDCD16.EvenFooterXsdstring? EvenFooterXsdstring
  {
    get
    {
      return _Element?.GetObject<DMDCD16.EvenFooterXsdstring,DXO16DCD.EvenFooterXsdstring>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.EvenFooterXsdstring,DXO16DCD.EvenFooterXsdstring>(value);
    }
  }
  
  
  /// <summary>
  ///   FirstHeaderXsdstring.
  /// </summary>
  [DataMember]
  public DMDCD16.FirstHeaderXsdstring? FirstHeaderXsdstring
  {
    get
    {
      return _Element?.GetObject<DMDCD16.FirstHeaderXsdstring,DXO16DCD.FirstHeaderXsdstring>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.FirstHeaderXsdstring,DXO16DCD.FirstHeaderXsdstring>(value);
    }
  }
  
  
  /// <summary>
  ///   FirstFooterXsdstring.
  /// </summary>
  [DataMember]
  public DMDCD16.FirstFooterXsdstring? FirstFooterXsdstring
  {
    get
    {
      return _Element?.GetObject<DMDCD16.FirstFooterXsdstring,DXO16DCD.FirstFooterXsdstring>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.FirstFooterXsdstring,DXO16DCD.FirstFooterXsdstring>(value);
    }
  }
  
}
