namespace DocumentModel.Wordprocessing;


/// <summary>
///   Single Frame Properties.
/// </summary>
public partial class Frame: ModelElement<DXW.Frame>
{
  public Frame(): base(){ }
  
  public Frame(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Frame(DXW.Frame openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Frame Size.
  /// </summary>
  [DataMember]
  public DMW.FrameSize? FrameSize
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.FrameSize>();
      if (element != null)
        return FrameSizeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.FrameSize>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FrameSizeConverter.CreateOpenXmlElement<DXW.FrameSize>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Frame Name.
  /// </summary>
  [DataMember]
  public DMW.FrameName? FrameName
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.FrameName>();
      if (element != null)
        return FrameNameConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.FrameName>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FrameNameConverter.CreateOpenXmlElement<DXW.FrameName>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Source File for Frame.
  /// </summary>
  [DataMember]
  public DMW.SourceFileReference? SourceFileReference
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.SourceFileReference>();
      if (element != null)
        return SourceFileReferenceConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.SourceFileReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SourceFileReferenceConverter.CreateOpenXmlElement<DXW.SourceFileReference>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Left and Right Margin for Frame.
  /// </summary>
  [DataMember]
  public DMW.MarginWidth? MarginWidth
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.MarginWidth>();
      if (element != null)
        return MarginWidthConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.MarginWidth>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MarginWidthConverter.CreateOpenXmlElement<DXW.MarginWidth>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Top and Bottom Margin for Frame.
  /// </summary>
  [DataMember]
  public DMW.MarginHeight? MarginHeight
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.MarginHeight>();
      if (element != null)
        return MarginHeightConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.MarginHeight>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MarginHeightConverter.CreateOpenXmlElement<DXW.MarginHeight>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Scrollbar Display Option.
  /// </summary>
  [DataMember]
  public DMW.FrameScrollbarVisibilityKind? ScrollbarVisibility
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.FrameScrollbarVisibilityValues, DMW.FrameScrollbarVisibilityKind>(_ExistingElement.GetFirstChild<DXW.ScrollbarVisibility>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.ScrollbarVisibility>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.FrameScrollbarVisibilityValues, DMW.FrameScrollbarVisibilityKind>(itemElement, (DMW.FrameScrollbarVisibilityKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.ScrollbarVisibility, DocumentFormat.OpenXml.Wordprocessing.FrameScrollbarVisibilityValues, DMW.FrameScrollbarVisibilityKind>((DMW.FrameScrollbarVisibilityKind)value));
    }
  }
  
  
  /// <summary>
  ///   Frame Cannot Be Resized.
  /// </summary>
  [DataMember]
  public DMW.NoResizeAllowed? NoResizeAllowed
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.NoResizeAllowed>();
      if (element != null)
        return NoResizeAllowedConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.NoResizeAllowed>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NoResizeAllowedConverter.CreateOpenXmlElement<DXW.NoResizeAllowed>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Maintain Link to Existing File.
  /// </summary>
  [DataMember]
  public DMW.LinkedToFile? LinkedToFile
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.LinkedToFile>();
      if (element != null)
        return LinkedToFileConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.LinkedToFile>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LinkedToFileConverter.CreateOpenXmlElement<DXW.LinkedToFile>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
