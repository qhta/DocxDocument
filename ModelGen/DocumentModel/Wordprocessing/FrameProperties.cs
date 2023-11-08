namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies information about the current paragraph with regard to text frames. Text frames are paragraphs of text in a document which are positioned in a separate region or frame in the document and can be positioned with a specific size and position relative to non-frame paragraphs in the current document.
/// </summary>
public partial class FrameProperties: ModelElement<DXW.FrameProperties>
{
  public FrameProperties(): base(){ }
  
  public FrameProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FrameProperties(DXW.FrameProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Drop Cap Vertical Height in Lines
  /// </summary>
  [DataMember]
  public Int32? Lines
  {
    get
    {
      return _Element?.Lines?.Value;
    }
    set
    {
      _ExistingElement.Lines = value;
    }
  }
  
  
  /// <summary>
  ///   Frame Width
  /// </summary>
  [DataMember]
  public String? Width
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Width);
    }
    set
    {
      _ExistingElement.Width = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Frame Height
  /// </summary>
  [DataMember]
  public UInt32? Height
  {
    get
    {
      return _Element?.Height?.Value;
    }
    set
    {
      _ExistingElement.Height = value;
    }
  }
  
  
  /// <summary>
  ///   Vertical Frame Padding
  /// </summary>
  [DataMember]
  public String? VerticalSpace
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.VerticalSpace);
    }
    set
    {
      _ExistingElement.VerticalSpace = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Horizontal Frame Padding
  /// </summary>
  [DataMember]
  public String? HorizontalSpace
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.HorizontalSpace);
    }
    set
    {
      _ExistingElement.HorizontalSpace = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Absolute Horizontal Position
  /// </summary>
  [DataMember]
  public String? X
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.X);
    }
    set
    {
      _ExistingElement.X = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Absolute Vertical Position
  /// </summary>
  [DataMember]
  public String? Y
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Y);
    }
    set
    {
      _ExistingElement.Y = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Lock Frame Anchor to Paragraph
  /// </summary>
  [DataMember]
  public Boolean? AnchorLock
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.AnchorLock);
    }
    set
    {
      _ExistingElement.AnchorLock = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
}
