namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the borders for the parent paragraph. Each child element shall specify a specific kind of border (left, right, bottom, top, and between).
/// </summary>
public partial class ParagraphBorders: ModelElement<DXW.ParagraphBorders>
{
  public ParagraphBorders(): base(){ }
  
  public ParagraphBorders(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ParagraphBorders(DXW.ParagraphBorders openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Paragraph Border Above Identical Paragraphs.
  /// </summary>
  [DataMember]
  public DMW.TopBorder? TopBorder
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.TopBorder>();
      if (element != null)
        return TopBorderConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.TopBorder>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TopBorderConverter.CreateOpenXmlElement<DXW.TopBorder>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Left Paragraph Border.
  /// </summary>
  [DataMember]
  public DMW.LeftBorder? LeftBorder
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.LeftBorder>();
      if (element != null)
        return LeftBorderConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.LeftBorder>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LeftBorderConverter.CreateOpenXmlElement<DXW.LeftBorder>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Paragraph Border Between Identical Paragraphs.
  /// </summary>
  [DataMember]
  public DMW.BottomBorder? BottomBorder
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.BottomBorder>();
      if (element != null)
        return BottomBorderConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.BottomBorder>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BottomBorderConverter.CreateOpenXmlElement<DXW.BottomBorder>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Right Paragraph Border.
  /// </summary>
  [DataMember]
  public DMW.RightBorder? RightBorder
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.RightBorder>();
      if (element != null)
        return RightBorderConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.RightBorder>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RightBorderConverter.CreateOpenXmlElement<DXW.RightBorder>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Paragraph Border Between Identical Paragraphs.
  /// </summary>
  [DataMember]
  public DMW.BetweenBorder? BetweenBorder
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.BetweenBorder>();
      if (element != null)
        return BetweenBorderConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.BetweenBorder>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BetweenBorderConverter.CreateOpenXmlElement<DXW.BetweenBorder>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Paragraph Border Between Facing Pages.
  /// </summary>
  [DataMember]
  public DMW.BarBorder? BarBorder
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.BarBorder>();
      if (element != null)
        return BarBorderConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.BarBorder>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BarBorderConverter.CreateOpenXmlElement<DXW.BarBorder>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
