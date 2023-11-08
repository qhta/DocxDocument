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
  ///   Table Left Border.
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
  ///   StartBorder, this property is only available in Office 2010 and later..
  /// </summary>
  [DataMember]
  public DMW.StartBorder? StartBorder
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.StartBorder>();
      if (element != null)
        return StartBorderConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.StartBorder>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StartBorderConverter.CreateOpenXmlElement<DXW.StartBorder>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
  ///   Table Right Border.
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
  ///   EndBorder, this property is only available in Office 2010 and later..
  /// </summary>
  [DataMember]
  public DMW.EndBorder? EndBorder
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.EndBorder>();
      if (element != null)
        return EndBorderConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.EndBorder>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EndBorderConverter.CreateOpenXmlElement<DXW.EndBorder>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.InsideHorizontalBorder>();
      if (element != null)
        return InsideHorizontalBorderConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.InsideHorizontalBorder>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = InsideHorizontalBorderConverter.CreateOpenXmlElement<DXW.InsideHorizontalBorder>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.InsideVerticalBorder>();
      if (element != null)
        return InsideVerticalBorderConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.InsideVerticalBorder>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = InsideVerticalBorderConverter.CreateOpenXmlElement<DXW.InsideVerticalBorder>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
