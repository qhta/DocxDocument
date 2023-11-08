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
        _ExistingElement.AlignWithMargins = new BooleanValue { Value = (Boolean)value };
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
        _ExistingElement.DifferentOddEven = new BooleanValue { Value = (Boolean)value };
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
        _ExistingElement.DifferentFirst = new BooleanValue { Value = (Boolean)value };
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
      var element = _Element?.GetFirstChild<DXO16DCD.OddHeaderXsdstring>();
      if (element != null)
        return OddHeaderXsdstringConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.OddHeaderXsdstring>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = OddHeaderXsdstringConverter.CreateOpenXmlElement<DXO16DCD.OddHeaderXsdstring>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXO16DCD.OddFooterXsdstring>();
      if (element != null)
        return OddFooterXsdstringConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.OddFooterXsdstring>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = OddFooterXsdstringConverter.CreateOpenXmlElement<DXO16DCD.OddFooterXsdstring>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXO16DCD.EvenHeaderXsdstring>();
      if (element != null)
        return EvenHeaderXsdstringConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.EvenHeaderXsdstring>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EvenHeaderXsdstringConverter.CreateOpenXmlElement<DXO16DCD.EvenHeaderXsdstring>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXO16DCD.EvenFooterXsdstring>();
      if (element != null)
        return EvenFooterXsdstringConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.EvenFooterXsdstring>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EvenFooterXsdstringConverter.CreateOpenXmlElement<DXO16DCD.EvenFooterXsdstring>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXO16DCD.FirstHeaderXsdstring>();
      if (element != null)
        return FirstHeaderXsdstringConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.FirstHeaderXsdstring>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FirstHeaderXsdstringConverter.CreateOpenXmlElement<DXO16DCD.FirstHeaderXsdstring>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXO16DCD.FirstFooterXsdstring>();
      if (element != null)
        return FirstFooterXsdstringConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.FirstFooterXsdstring>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FirstFooterXsdstringConverter.CreateOpenXmlElement<DXO16DCD.FirstFooterXsdstring>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
