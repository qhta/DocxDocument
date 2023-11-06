namespace DocumentModel.Wordprocessing;

/// <summary>
/// This class specifies the theme color, stored in the document's Theme part to which the value of this theme color shall be mapped. 
/// This mapping enables multiple theme colors to be chained together.
/// </summary>
[DataContract]
public partial class ColorSchemeMapping : ModelElement<DXW.ColorSchemeMapping>
{
  public ColorSchemeMapping(): base(){ }

  public ColorSchemeMapping(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }

  public ColorSchemeMapping(DXW.ColorSchemeMapping openXmlElement): base(openXmlElement) { }

  /// <summary>
  /// Background 1 Theme Color Mapping
  /// </summary>
  [DataMember]
  public DMW.ColorSchemeIndexKind? Background1
  {
    get => _Element.Background1?.GetEnumValue<DMW.ColorSchemeIndexKind, DXW.ColorSchemeIndexValues>();
    set => _Element.Background1 = EVU.SetEnumValue<DMW.ColorSchemeIndexKind, DXW.ColorSchemeIndexValues>(value);
  }

  /// <summary>
  /// Text 1 Theme Color Mapping
  /// </summary>
  [DataMember]
  public DMW.ColorSchemeIndexKind? Text1
  {
    get => _Element.Text1?.GetEnumValue<DMW.ColorSchemeIndexKind, DXW.ColorSchemeIndexValues>();
    set => _Element.Text1 = EVU.SetEnumValue<DMW.ColorSchemeIndexKind, DXW.ColorSchemeIndexValues>(value);
  }

  /// <summary>
  /// Background 2 Theme Color Mapping
  /// </summary>
  [DataMember]
  public DMW.ColorSchemeIndexKind? Background2
  {
    get => _Element.Background2?.GetEnumValue<DMW.ColorSchemeIndexKind, DXW.ColorSchemeIndexValues>();
    set => _Element.Background2 = EVU.SetEnumValue<DMW.ColorSchemeIndexKind, DXW.ColorSchemeIndexValues>(value);
  }

  /// <summary>
  /// Text 2 Theme Color Mapping
  /// </summary>
  [DataMember]
  public DMW.ColorSchemeIndexKind? Text2
  {
    get => _Element.Text2?.GetEnumValue<DMW.ColorSchemeIndexKind, DXW.ColorSchemeIndexValues>();
    set => _Element.Text2 = EVU.SetEnumValue<DMW.ColorSchemeIndexKind, DXW.ColorSchemeIndexValues>(value);
  }

  /// <summary>
  /// Accent 1 Theme Color Mapping
  /// </summary>
  [DataMember]
  public DMW.ColorSchemeIndexKind? Accent1
  {
    get => _Element.Accent1?.GetEnumValue<DMW.ColorSchemeIndexKind, DXW.ColorSchemeIndexValues>();
    set => _Element.Accent1 = EVU.SetEnumValue<DMW.ColorSchemeIndexKind, DXW.ColorSchemeIndexValues>(value);
  }

  /// <summary>
  /// Accent 2 Theme Color Mapping
  /// </summary>
  [DataMember]
  public DMW.ColorSchemeIndexKind? Accent2
  {
    get => _Element.Accent2?.GetEnumValue<DMW.ColorSchemeIndexKind, DXW.ColorSchemeIndexValues>();
    set => _Element.Accent2 = EVU.SetEnumValue<DMW.ColorSchemeIndexKind, DXW.ColorSchemeIndexValues>(value);
  }

  /// <summary>
  /// Accent3 Theme Color Mapping
  /// </summary>
  [DataMember]
  public DMW.ColorSchemeIndexKind? Accent3
  {
    get => _Element.Accent3?.GetEnumValue<DMW.ColorSchemeIndexKind, DXW.ColorSchemeIndexValues>();
    set => _Element.Accent3 = EVU.SetEnumValue<DMW.ColorSchemeIndexKind, DXW.ColorSchemeIndexValues>(value);
  }

  /// <summary>
  /// Accent4 Theme Color Mapping
  /// </summary>
  [DataMember]
  public DMW.ColorSchemeIndexKind? Accent4
  {
    get => _Element.Accent4?.GetEnumValue<DMW.ColorSchemeIndexKind, DXW.ColorSchemeIndexValues>();
    set => _Element.Accent4 = EVU.SetEnumValue<DMW.ColorSchemeIndexKind, DXW.ColorSchemeIndexValues>(value);
  }

  /// <summary>
  /// Accent5 Theme Color Mapping
  /// </summary>
  [DataMember]
  public DMW.ColorSchemeIndexKind? Accent5
  {
    get => _Element.Accent5?.GetEnumValue<DMW.ColorSchemeIndexKind, DXW.ColorSchemeIndexValues>();
    set => _Element.Accent5 = EVU.SetEnumValue<DMW.ColorSchemeIndexKind, DXW.ColorSchemeIndexValues>(value);
  }

  /// <summary>
  /// Accent6 Theme Color Mapping
  /// </summary>
  [DataMember]
  public DMW.ColorSchemeIndexKind? Accent6
  {
    get => _Element.Accent6?.GetEnumValue<DMW.ColorSchemeIndexKind, DXW.ColorSchemeIndexValues>();
    set => _Element.Accent6 = EVU.SetEnumValue<DMW.ColorSchemeIndexKind, DXW.ColorSchemeIndexValues>(value);
  }

  /// <summary>
  /// Hyperlink Theme Color Mapping
  /// </summary>
  [DataMember]
  public DMW.ColorSchemeIndexKind? Hyperlink
  {
    get => _Element.Hyperlink?.GetEnumValue<DMW.ColorSchemeIndexKind, DXW.ColorSchemeIndexValues>();
    set => _Element.Hyperlink = EVU.SetEnumValue<DMW.ColorSchemeIndexKind, DXW.ColorSchemeIndexValues>(value);
  }

  /// <summary>
  /// Followed Hyperlink Theme Color Mapping
  /// </summary>
  [DataMember]
  public DMW.ColorSchemeIndexKind? FollowedHyperlink
  {
    get => _Element.FollowedHyperlink?.GetEnumValue<DMW.ColorSchemeIndexKind, DXW.ColorSchemeIndexValues>();
    set => _Element.FollowedHyperlink = EVU.SetEnumValue<DMW.ColorSchemeIndexKind, DXW.ColorSchemeIndexValues>(value);
  }

}
