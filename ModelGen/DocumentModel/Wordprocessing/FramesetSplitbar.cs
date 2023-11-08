namespace DocumentModel.Wordprocessing;


/// <summary>
///   Frameset Splitter Properties.
/// </summary>
public partial class FramesetSplitbar: ModelElement<DXW.FramesetSplitbar>
{
  public FramesetSplitbar(): base(){ }
  
  public FramesetSplitbar(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FramesetSplitbar(DXW.FramesetSplitbar openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Frameset Splitter Width.
  /// </summary>
  [DataMember]
  public DMW.Width? Width
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.Width>();
      if (element != null)
        return WidthConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.Width>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = WidthConverter.CreateOpenXmlElement<DXW.Width>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Frameset Splitter Color.
  /// </summary>
  [DataMember]
  public DMW.Color? Color
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.Color>();
      if (element != null)
        return ColorConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.Color>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ColorConverter.CreateOpenXmlElement<DXW.Color>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Do Not Display Frameset Splitters.
  /// </summary>
  [DataMember]
  public DMW.NoBorder? NoBorder
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.NoBorder>();
      if (element != null)
        return NoBorderConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.NoBorder>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NoBorderConverter.CreateOpenXmlElement<DXW.NoBorder>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Frameset Splitter Border Style.
  /// </summary>
  [DataMember]
  public DMW.FlatBorders? FlatBorders
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.FlatBorders>();
      if (element != null)
        return FlatBordersConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.FlatBorders>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FlatBordersConverter.CreateOpenXmlElement<DXW.FlatBorders>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
