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
      return _Element?.GetObject<DMW.Width,DXW.Width>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.Width,DXW.Width>(value);
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
      return _Element?.GetObject<DMW.Color,DXW.Color>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.Color,DXW.Color>(value);
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
      return _Element?.GetObject<DMW.NoBorder,DXW.NoBorder>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.NoBorder,DXW.NoBorder>(value);
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
      return _Element?.GetObject<DMW.FlatBorders,DXW.FlatBorders>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.FlatBorders,DXW.FlatBorders>(value);
    }
  }
  
}
