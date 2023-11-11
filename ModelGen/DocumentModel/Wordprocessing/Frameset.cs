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
      return _Element?.GetObject<DMW.FrameSize,DXW.FrameSize>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.FrameSize,DXW.FrameSize>(value);
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
      return _Element?.GetObject<DMW.FramesetSplitbar,DXW.FramesetSplitbar>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.FramesetSplitbar,DXW.FramesetSplitbar>(value);
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
