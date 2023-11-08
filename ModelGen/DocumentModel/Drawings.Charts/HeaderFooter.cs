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
        _ExistingElement.AlignWithMargins = new BooleanValue { Value = (Boolean)value };
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
        _ExistingElement.DifferentOddEven = new BooleanValue { Value = (Boolean)value };
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
        _ExistingElement.DifferentFirst = new BooleanValue { Value = (Boolean)value };
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
      var element = _Element?.GetFirstChild<DXDC.OddHeader>();
      if (element != null)
        return OddHeaderConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.OddHeader>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = OddHeaderConverter.CreateOpenXmlElement<DXDC.OddHeader>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXDC.OddFooter>();
      if (element != null)
        return OddFooterConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.OddFooter>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = OddFooterConverter.CreateOpenXmlElement<DXDC.OddFooter>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXDC.EvenHeader>();
      if (element != null)
        return EvenHeaderConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.EvenHeader>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EvenHeaderConverter.CreateOpenXmlElement<DXDC.EvenHeader>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXDC.EvenFooter>();
      if (element != null)
        return EvenFooterConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.EvenFooter>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EvenFooterConverter.CreateOpenXmlElement<DXDC.EvenFooter>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXDC.FirstHeader>();
      if (element != null)
        return FirstHeaderConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.FirstHeader>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FirstHeaderConverter.CreateOpenXmlElement<DXDC.FirstHeader>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXDC.FirstFooter>();
      if (element != null)
        return FirstFooterConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.FirstFooter>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FirstFooterConverter.CreateOpenXmlElement<DXDC.FirstFooter>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
