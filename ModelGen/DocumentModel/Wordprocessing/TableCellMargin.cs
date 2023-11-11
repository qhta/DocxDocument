namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies a set of cell margins for a single table cell in the parent table.
/// </summary>
public partial class TableCellMargin: ModelElement<DXW.TableCellMargin>
{
  public TableCellMargin(): base(){ }
  
  public TableCellMargin(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TableCellMargin(DXW.TableCellMargin openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Table Cell Top Margin Exception.
  /// </summary>
  [DataMember]
  public DMW.TopMargin? TopMargin
  {
    get
    {
      return _Element?.GetObject<DMW.TopMargin,DXW.TopMargin>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.TopMargin,DXW.TopMargin>(value);
    }
  }
  
  
  /// <summary>
  ///   Table Cell Left Margin Exception.
  /// </summary>
  [DataMember]
  public DMW.LeftMargin? LeftMargin
  {
    get
    {
      return _Element?.GetObject<DMW.LeftMargin,DXW.LeftMargin>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.LeftMargin,DXW.LeftMargin>(value);
    }
  }
  
  
  /// <summary>
  ///   StartMargin, this property is only available in Office 2010 and later..
  /// </summary>
  [DataMember]
  public DMW.StartMargin? StartMargin
  {
    get
    {
      return _Element?.GetObject<DMW.StartMargin,DXW.StartMargin>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.StartMargin,DXW.StartMargin>(value);
    }
  }
  
  
  /// <summary>
  ///   Table Cell Bottom Margin Exception.
  /// </summary>
  [DataMember]
  public DMW.BottomMargin? BottomMargin
  {
    get
    {
      return _Element?.GetObject<DMW.BottomMargin,DXW.BottomMargin>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.BottomMargin,DXW.BottomMargin>(value);
    }
  }
  
  
  /// <summary>
  ///   Table Cell Right Margin Exception.
  /// </summary>
  [DataMember]
  public DMW.RightMargin? RightMargin
  {
    get
    {
      return _Element?.GetObject<DMW.RightMargin,DXW.RightMargin>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.RightMargin,DXW.RightMargin>(value);
    }
  }
  
  
  /// <summary>
  ///   EndMargin, this property is only available in Office 2010 and later..
  /// </summary>
  [DataMember]
  public DMW.EndMargin? EndMargin
  {
    get
    {
      return _Element?.GetObject<DMW.EndMargin,DXW.EndMargin>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.EndMargin,DXW.EndMargin>(value);
    }
  }
  
}
