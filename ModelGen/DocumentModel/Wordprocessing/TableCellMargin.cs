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
  ///   Table Cell Left Margin Exception.
  /// </summary>
  [DataMember]
  public DMW.LeftMargin? LeftMargin
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.LeftMargin>();
      if (element != null)
        return LeftMarginConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.LeftMargin>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LeftMarginConverter.CreateOpenXmlElement<DXW.LeftMargin>(value);
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
  ///   Table Cell Bottom Margin Exception.
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
  ///   Table Cell Right Margin Exception.
  /// </summary>
  [DataMember]
  public DMW.RightMargin? RightMargin
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.RightMargin>();
      if (element != null)
        return RightMarginConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.RightMargin>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RightMarginConverter.CreateOpenXmlElement<DXW.RightMargin>(value);
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
