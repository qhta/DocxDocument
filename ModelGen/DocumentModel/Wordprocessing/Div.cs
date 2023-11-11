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
      return _Element?.GetObject<DMW.BlockQuote,DXW.BlockQuote>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.BlockQuote,DXW.BlockQuote>(value);
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
      return _Element?.GetObject<DMW.BodyDiv,DXW.BodyDiv>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.BodyDiv,DXW.BodyDiv>(value);
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
      return _Element?.GetObject<DMW.LeftMarginDiv,DXW.LeftMarginDiv>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.LeftMarginDiv,DXW.LeftMarginDiv>(value);
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
      return _Element?.GetObject<DMW.RightMarginDiv,DXW.RightMarginDiv>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.RightMarginDiv,DXW.RightMarginDiv>(value);
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
      return _Element?.GetObject<DMW.TopMarginDiv,DXW.TopMarginDiv>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.TopMarginDiv,DXW.TopMarginDiv>(value);
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
      return _Element?.GetObject<DMW.BottomMarginDiv,DXW.BottomMarginDiv>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.BottomMarginDiv,DXW.BottomMarginDiv>(value);
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
      return _Element?.GetObject<DMW.DivBorder,DXW.DivBorder>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DivBorder,DXW.DivBorder>(value);
    }
  }
  
}
