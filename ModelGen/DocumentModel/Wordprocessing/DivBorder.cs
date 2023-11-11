namespace DocumentModel.Wordprocessing;


/// <summary>
///   Set of Borders for HTML div.
/// </summary>
public partial class DivBorder: ModelElement<DXW.DivBorder>
{
  public DivBorder(): base(){ }
  
  public DivBorder(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DivBorder(DXW.DivBorder openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Top Border for HTML div.
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
  ///   Left Border for HTML div.
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
  ///   Bottom Border for HTML div.
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
  ///   Right Border for HTML div.
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
