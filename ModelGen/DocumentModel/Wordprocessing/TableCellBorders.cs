namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the set of borders for the edges of the current table cell, using the eight border types defined by its child elements.
/// </summary>
public partial class TableCellBorders: ModelElement<DXW.TableCellBorders>
{
  public TableCellBorders(): base(){ }
  
  public TableCellBorders(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TableCellBorders(DXW.TableCellBorders openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Table Cell Top Border.
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
  ///   Table Cell Left Border.
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
  ///   Table Cell Bottom Border.
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
  ///   Table Cell Right Border.
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
  ///   Table Cell Inside Horizontal Edges Border.
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
  ///   Table Cell Inside Vertical Edges Border.
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
  
  
  /// <summary>
  ///   Table Cell Top Left to Bottom Right Diagonal Border.
  /// </summary>
  [DataMember]
  public DMW.TopLeftToBottomRightCellBorder? TopLeftToBottomRightCellBorder
  {
    get
    {
      return _Element?.GetObject<DMW.TopLeftToBottomRightCellBorder,DXW.TopLeftToBottomRightCellBorder>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.TopLeftToBottomRightCellBorder,DXW.TopLeftToBottomRightCellBorder>(value);
    }
  }
  
  
  /// <summary>
  ///   Table Cell Top Right to Bottom Left Diagonal Border.
  /// </summary>
  [DataMember]
  public DMW.TopRightToBottomLeftCellBorder? TopRightToBottomLeftCellBorder
  {
    get
    {
      return _Element?.GetObject<DMW.TopRightToBottomLeftCellBorder,DXW.TopRightToBottomLeftCellBorder>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.TopRightToBottomLeftCellBorder,DXW.TopRightToBottomLeftCellBorder>(value);
    }
  }
  
}
