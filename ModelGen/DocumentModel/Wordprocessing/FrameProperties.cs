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
    get => _Element?.Lines?.Value;
    set => _ExistingElement.Lines = value;
  }
  
  
  /// <summary>
  ///   Frame Width
  /// </summary>
  [DataMember]
  public String? Width
  {
    get => _Element?.Width;
    set => _ExistingElement.Width = value;
  }
  
  
  /// <summary>
  ///   Frame Height
  /// </summary>
  [DataMember]
  public UInt32? Height
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
  }
  
  
  /// <summary>
  ///   Vertical Frame Padding
  /// </summary>
  [DataMember]
  public String? VerticalSpace
  {
    get => _Element?.VerticalSpace;
    set => _ExistingElement.VerticalSpace = value;
  }
  
  
  /// <summary>
  ///   Horizontal Frame Padding
  /// </summary>
  [DataMember]
  public String? HorizontalSpace
  {
    get => _Element?.HorizontalSpace;
    set => _ExistingElement.HorizontalSpace = value;
  }
  
  
  /// <summary>
  ///   Absolute Horizontal Position
  /// </summary>
  [DataMember]
  public String? X
  {
    get => _Element?.X;
    set => _ExistingElement.X = value;
  }
  
  
  /// <summary>
  ///   Absolute Vertical Position
  /// </summary>
  [DataMember]
  public String? Y
  {
    get => _Element?.Y;
    set => _ExistingElement.Y = value;
  }
  
  
  /// <summary>
  ///   Lock Frame Anchor to Paragraph
  /// </summary>
  [DataMember]
  public Boolean? AnchorLock
  {
    get => throw new NotImplementedException("Not implemented in GenerateBooleanPropertyGetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
    set => throw new NotImplementedException("Not implemented in GenerateBooleanPropertySetCode: boolean propertyType is DocumentFormat.OpenXml.OnOffValue");
  }
  
}
