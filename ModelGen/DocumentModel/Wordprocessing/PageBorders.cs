namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the PageBorders Class.
/// </summary>
public partial class PageBorders: ModelElement<DXW.PageBorders>
{
  public PageBorders(): base(){ }
  
  public PageBorders(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PageBorders(DXW.PageBorders openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Top Border.
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
  ///   Left Border.
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
  ///   Bottom Border.
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
  ///   Right Border.
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
  
}
