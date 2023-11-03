namespace DocumentModel.Wordprocessing;

/// <summary>
/// This class specifies the theme color, stored in the document's Theme part to which the value of this theme color shall be mapped. 
/// This mapping enables multiple theme colors to be chained together.
/// </summary>
[DataContract]
public partial class ColorSchemeMapping : IOpenXmlElementMappedObject
{
  public ColorSchemeMapping()
  {
    _Element = new DXW.ColorSchemeMapping();
  }

  public ColorSchemeMapping(DX.OpenXmlElement openXmlElement)
  {
    _Element = (DXW.ColorSchemeMapping)openXmlElement;
  }

  public OpenXmlElementType GetElement<OpenXmlElementType>() where OpenXmlElementType : DX.OpenXmlElement
  {
    if (_Element is OpenXmlElementType validTypeElement)
      return validTypeElement;
    throw new ArgumentException($"Only {_Element.GetType()} type supported in GetElement of {this.GetType()}");
  }

  public ColorSchemeMapping(DXW.ColorSchemeMapping openXmlElement)
  {
    _Element = openXmlElement;
  }

  internal DXW.ColorSchemeMapping _Element { get; private set; }

  /// <summary>
  /// Background 1 Theme Color Mapping
  /// </summary>
  [DataMember]
  public DXW.ColorSchemeIndexValues? Background1
  {
    get => _Element.Background1?.Value;
    set => _Element.Background1 = value;
  }

  /// <summary>
  /// Text 1 Theme Color Mapping
  /// </summary>
  [DataMember]
  public DXW.ColorSchemeIndexValues? Text1
  {
    get => _Element.Text1?.Value;
    set => _Element.Text1 = value;
  }

  /// <summary>
  /// Background 2 Theme Color Mapping
  /// </summary>
  [DataMember]
  public DXW.ColorSchemeIndexValues? Background2
  {
    get => _Element.Background2?.Value;
    set => _Element.Background2 = value;
  }

  /// <summary>
  /// Text 2 Theme Color Mapping
  /// </summary>
  [DataMember]
  public DXW.ColorSchemeIndexValues? Text2
  {
    get => _Element.Text2?.Value;
    set => _Element.Text2 = value;
  }

  /// <summary>
  /// Accent 1 Theme Color Mapping
  /// </summary>
  [DataMember]
  public DXW.ColorSchemeIndexValues? Accent1
  {
    get => _Element.Accent1?.Value;
    set => _Element.Accent1 = value;
  }

  /// <summary>
  /// Accent 2 Theme Color Mapping
  /// </summary>
  [DataMember]
  public DXW.ColorSchemeIndexValues? Accent2
  {
    get => _Element.Accent2?.Value;
    set => _Element.Accent2 = value;
  }

  /// <summary>
  /// Accent3 Theme Color Mapping
  /// </summary>
  [DataMember]
  public DXW.ColorSchemeIndexValues? Accent3
  {
    get => _Element.Accent3?.Value;
    set => _Element.Accent3 = value;
  }

  /// <summary>
  /// Accent4 Theme Color Mapping
  /// </summary>
  [DataMember]
  public DXW.ColorSchemeIndexValues? Accent4
  {
    get => _Element.Accent4?.Value;
    set => _Element.Accent4 = value;
  }

  /// <summary>
  /// Accent5 Theme Color Mapping
  /// </summary>
  [DataMember]
  public DXW.ColorSchemeIndexValues? Accent5
  {
    get => _Element.Accent5?.Value;
    set => _Element.Accent5 = value;
  }

  /// <summary>
  /// Accent6 Theme Color Mapping
  /// </summary>
  [DataMember]
  public DXW.ColorSchemeIndexValues? Accent6
  {
    get => _Element.Accent6?.Value;
    set => _Element.Accent6 = value;
  }

  /// <summary>
  /// Hyperlink Theme Color Mapping
  /// </summary>
  [DataMember]
  public DXW.ColorSchemeIndexValues? Hyperlink
  {
    get => _Element.Hyperlink?.Value;
    set => _Element.Hyperlink = value;
  }

  /// <summary>
  /// Followed Hyperlink Theme Color Mapping
  /// </summary>
  [DataMember]
  public DXW.ColorSchemeIndexValues? FollowedHyperlink
  {
    get => _Element.FollowedHyperlink?.Value;
    set => _Element.FollowedHyperlink = value;
  }

}
