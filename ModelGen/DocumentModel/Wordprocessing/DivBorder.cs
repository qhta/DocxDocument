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
  ///   Left Border for HTML div.
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
  ///   Bottom Border for HTML div.
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
  ///   Right Border for HTML div.
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
  
}
