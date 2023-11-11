namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Header and Footer.
/// </summary>
public partial class HeaderFooter: ModelElement<DXDC.HeaderFooter>
{
  public HeaderFooter(): base(){ }
  
  public HeaderFooter(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public HeaderFooter(DXDC.HeaderFooter openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Align With Margins
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
  ///   Different Odd Even
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
  ///   Different First
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
  ///   Odd Header.
  /// </summary>
  [DataMember]
  public DMDC.OddHeader? OddHeader
  {
    get
    {
      return _Element?.GetObject<DMDC.OddHeader,DXDC.OddHeader>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.OddHeader,DXDC.OddHeader>(value);
    }
  }
  
  
  /// <summary>
  ///   Odd Footer.
  /// </summary>
  [DataMember]
  public DMDC.OddFooter? OddFooter
  {
    get
    {
      return _Element?.GetObject<DMDC.OddFooter,DXDC.OddFooter>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.OddFooter,DXDC.OddFooter>(value);
    }
  }
  
  
  /// <summary>
  ///   Even Header.
  /// </summary>
  [DataMember]
  public DMDC.EvenHeader? EvenHeader
  {
    get
    {
      return _Element?.GetObject<DMDC.EvenHeader,DXDC.EvenHeader>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.EvenHeader,DXDC.EvenHeader>(value);
    }
  }
  
  
  /// <summary>
  ///   Even Footer.
  /// </summary>
  [DataMember]
  public DMDC.EvenFooter? EvenFooter
  {
    get
    {
      return _Element?.GetObject<DMDC.EvenFooter,DXDC.EvenFooter>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.EvenFooter,DXDC.EvenFooter>(value);
    }
  }
  
  
  /// <summary>
  ///   First Header.
  /// </summary>
  [DataMember]
  public DMDC.FirstHeader? FirstHeader
  {
    get
    {
      return _Element?.GetObject<DMDC.FirstHeader,DXDC.FirstHeader>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.FirstHeader,DXDC.FirstHeader>(value);
    }
  }
  
  
  /// <summary>
  ///   First Footer.
  /// </summary>
  [DataMember]
  public DMDC.FirstFooter? FirstFooter
  {
    get
    {
      return _Element?.GetObject<DMDC.FirstFooter,DXDC.FirstFooter>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.FirstFooter,DXDC.FirstFooter>(value);
    }
  }
  
}
