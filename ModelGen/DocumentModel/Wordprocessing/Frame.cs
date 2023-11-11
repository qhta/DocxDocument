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
      return _Element?.GetObject<DMW.FrameSize,DXW.FrameSize>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.FrameSize,DXW.FrameSize>(value);
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
      return _Element?.GetObject<DMW.FrameName,DXW.FrameName>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.FrameName,DXW.FrameName>(value);
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
      return _Element?.GetObject<DMW.SourceFileReference,DXW.SourceFileReference>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.SourceFileReference,DXW.SourceFileReference>(value);
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
      return _Element?.GetObject<DMW.MarginWidth,DXW.MarginWidth>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.MarginWidth,DXW.MarginWidth>(value);
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
      return _Element?.GetObject<DMW.MarginHeight,DXW.MarginHeight>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.MarginHeight,DXW.MarginHeight>(value);
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
      return _Element?.GetObject<DMW.NoResizeAllowed,DXW.NoResizeAllowed>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.NoResizeAllowed,DXW.NoResizeAllowed>(value);
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
      return _Element?.GetObject<DMW.LinkedToFile,DXW.LinkedToFile>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.LinkedToFile,DXW.LinkedToFile>(value);
    }
  }
  
}
