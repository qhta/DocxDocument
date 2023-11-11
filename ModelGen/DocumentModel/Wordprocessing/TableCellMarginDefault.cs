namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies a set of cell margins for all cells in the parent table row via a set of table-level property exceptions. These settings can be overridden by the table cell margin definition specified by the tcMar element contained within the table cell's properties.
/// </summary>
public partial class TableCellMarginDefault: ModelElement<DXW.TableCellMarginDefault>
{
  public TableCellMarginDefault(): base(){ }
  
  public TableCellMarginDefault(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TableCellMarginDefault(DXW.TableCellMarginDefault openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Table Cell Top Margin Default.
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
  ///   Table Cell Left Margin Default.
  /// </summary>
  [DataMember]
  public DMW.TableCellLeftMargin? TableCellLeftMargin
  {
    get
    {
      return _Element?.GetObject<DMW.TableCellLeftMargin,DXW.TableCellLeftMargin>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.TableCellLeftMargin,DXW.TableCellLeftMargin>(value);
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
  ///   Table Cell Bottom Margin Default.
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
  ///   Table Cell Right Margin Default.
  /// </summary>
  [DataMember]
  public DMW.TableCellRightMargin? TableCellRightMargin
  {
    get
    {
      return _Element?.GetObject<DMW.TableCellRightMargin,DXW.TableCellRightMargin>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.TableCellRightMargin,DXW.TableCellRightMargin>(value);
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
