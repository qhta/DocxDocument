namespace DocumentModel.Wordprocessing;


/// <summary>
///   Nested Frameset Definition.
/// </summary>
public partial class Frameset: ModelElement<DXW.Frameset>
{
  public Frameset(): base(){ }
  
  public Frameset(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Frameset(DXW.Frameset openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Nested Frameset Size.
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
  ///   Frameset Splitter Properties.
  /// </summary>
  [DataMember]
  public DMW.FramesetSplitbar? FramesetSplitbar
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.FramesetSplitbar>();
      if (element != null)
        return FramesetSplitbarConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.FramesetSplitbar>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FramesetSplitbarConverter.CreateOpenXmlElement<DXW.FramesetSplitbar>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Frameset Layout.
  /// </summary>
  [DataMember]
  public DMW.FrameLayoutKind? FrameLayout
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.FrameLayoutValues, DMW.FrameLayoutKind>(_ExistingElement.GetFirstChild<DXW.FrameLayout>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.FrameLayout>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.FrameLayoutValues, DMW.FrameLayoutKind>(itemElement, (DMW.FrameLayoutKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.FrameLayout, DocumentFormat.OpenXml.Wordprocessing.FrameLayoutValues, DMW.FrameLayoutKind>((DMW.FrameLayoutKind)value));
    }
  }
  
}
