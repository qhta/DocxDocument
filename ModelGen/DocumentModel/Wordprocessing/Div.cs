namespace DocumentModel.Wordprocessing;


/// <summary>
///   Information About Single HTML div Element.
/// </summary>
public partial class Div: ModelElement<DXW.Div>
{
  public Div(): base(){ }
  
  public Div(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Div(DXW.Div openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   div Data ID
  /// </summary>
  [DataMember]
  public String? Id
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Id);
    }
    set
    {
      _ExistingElement.Id = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Data for HTML blockquote Element.
  /// </summary>
  [DataMember]
  public DMW.BlockQuote? BlockQuote
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.BlockQuote>();
      if (element != null)
        return BlockQuoteConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.BlockQuote>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BlockQuoteConverter.CreateOpenXmlElement<DXW.BlockQuote>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Data for HTML body Element.
  /// </summary>
  [DataMember]
  public DMW.BodyDiv? BodyDiv
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.BodyDiv>();
      if (element != null)
        return BodyDivConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.BodyDiv>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BodyDivConverter.CreateOpenXmlElement<DXW.BodyDiv>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Left Margin for HTML div.
  /// </summary>
  [DataMember]
  public DMW.LeftMarginDiv? LeftMarginDiv
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.LeftMarginDiv>();
      if (element != null)
        return LeftMarginDivConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.LeftMarginDiv>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LeftMarginDivConverter.CreateOpenXmlElement<DXW.LeftMarginDiv>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Right Margin for HTML div.
  /// </summary>
  [DataMember]
  public DMW.RightMarginDiv? RightMarginDiv
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.RightMarginDiv>();
      if (element != null)
        return RightMarginDivConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.RightMarginDiv>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RightMarginDivConverter.CreateOpenXmlElement<DXW.RightMarginDiv>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Top Margin for HTML div.
  /// </summary>
  [DataMember]
  public DMW.TopMarginDiv? TopMarginDiv
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.TopMarginDiv>();
      if (element != null)
        return TopMarginDivConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.TopMarginDiv>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TopMarginDivConverter.CreateOpenXmlElement<DXW.TopMarginDiv>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Bottom Margin for HTML div.
  /// </summary>
  [DataMember]
  public DMW.BottomMarginDiv? BottomMarginDiv
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.BottomMarginDiv>();
      if (element != null)
        return BottomMarginDivConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.BottomMarginDiv>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BottomMarginDivConverter.CreateOpenXmlElement<DXW.BottomMarginDiv>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Set of Borders for HTML div.
  /// </summary>
  [DataMember]
  public DMW.DivBorder? DivBorder
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.DivBorder>();
      if (element != null)
        return DivBorderConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DivBorder>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DivBorderConverter.CreateOpenXmlElement<DXW.DivBorder>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
