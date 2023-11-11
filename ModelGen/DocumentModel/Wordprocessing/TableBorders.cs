namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the set of borders for the edges of the current table, using the six border types defined by its child elements.
/// </summary>
public partial class TableBorders: ModelElement<DXW.TableBorders>
{
  public TableBorders(): base(){ }
  
  public TableBorders(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TableBorders(DXW.TableBorders openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Table Top Border.
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
  ///   Table Left Border.
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
  ///   StartBorder, this property is only available in Office 2010 and later..
  /// </summary>
  [DataMember]
  public DMW.StartBorder? StartBorder
  {
    get
    {
      return _Element?.GetObject<DMW.StartBorder,DXW.StartBorder>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.StartBorder,DXW.StartBorder>(value);
    }
  }
  
  
  /// <summary>
  ///   Table Bottom Border.
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
  ///   Table Right Border.
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
  ///   EndBorder, this property is only available in Office 2010 and later..
  /// </summary>
  [DataMember]
  public DMW.EndBorder? EndBorder
  {
    get
    {
      return _Element?.GetObject<DMW.EndBorder,DXW.EndBorder>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.EndBorder,DXW.EndBorder>(value);
    }
  }
  
  
  /// <summary>
  ///   Table Inside Horizontal Edges Border.
  /// </summary>
  [DataMember]
  public DMW.InsideHorizontalBorder? InsideHorizontalBorder
  {
    get
    {
      return _Element?.GetObject<DMW.InsideHorizontalBorder,DXW.InsideHorizontalBorder>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.InsideHorizontalBorder,DXW.InsideHorizontalBorder>(value);
    }
  }
  
  
  /// <summary>
  ///   Table Inside Vertical Edges Border.
  /// </summary>
  [DataMember]
  public DMW.InsideVerticalBorder? InsideVerticalBorder
  {
    get
    {
      return _Element?.GetObject<DMW.InsideVerticalBorder,DXW.InsideVerticalBorder>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.InsideVerticalBorder,DXW.InsideVerticalBorder>(value);
    }
  }
  
}
