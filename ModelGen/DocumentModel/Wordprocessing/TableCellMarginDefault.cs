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
      var element = _Element?.GetFirstChild<DXW.TopMargin>();
      if (element != null)
        return TopMarginConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.TopMargin>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TopMarginConverter.CreateOpenXmlElement<DXW.TopMargin>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.TableCellLeftMargin>();
      if (element != null)
        return TableCellLeftMarginConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.TableCellLeftMargin>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TableCellLeftMarginConverter.CreateOpenXmlElement<DXW.TableCellLeftMargin>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.StartMargin>();
      if (element != null)
        return StartMarginConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.StartMargin>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StartMarginConverter.CreateOpenXmlElement<DXW.StartMargin>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.BottomMargin>();
      if (element != null)
        return BottomMarginConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.BottomMargin>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BottomMarginConverter.CreateOpenXmlElement<DXW.BottomMargin>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.TableCellRightMargin>();
      if (element != null)
        return TableCellRightMarginConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.TableCellRightMargin>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TableCellRightMarginConverter.CreateOpenXmlElement<DXW.TableCellRightMargin>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.EndMargin>();
      if (element != null)
        return EndMarginConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.EndMargin>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EndMarginConverter.CreateOpenXmlElement<DXW.EndMargin>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
