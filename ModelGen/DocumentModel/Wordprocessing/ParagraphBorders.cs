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
      return _Element?.GetObject<DMW.TopBorder,DXW.TopBorder>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.TopBorder,DXW.TopBorder>(value);
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
      return _Element?.GetObject<DMW.LeftBorder,DXW.LeftBorder>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.LeftBorder,DXW.LeftBorder>(value);
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
      return _Element?.GetObject<DMW.BottomBorder,DXW.BottomBorder>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.BottomBorder,DXW.BottomBorder>(value);
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
      return _Element?.GetObject<DMW.RightBorder,DXW.RightBorder>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.RightBorder,DXW.RightBorder>(value);
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
      return _Element?.GetObject<DMW.BetweenBorder,DXW.BetweenBorder>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.BetweenBorder,DXW.BetweenBorder>(value);
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
      return _Element?.GetObject<DMW.BarBorder,DXW.BarBorder>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.BarBorder,DXW.BarBorder>(value);
    }
  }
  
}
