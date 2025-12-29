namespace DocumentModel.Wordprocessing;

/// <summary>
/// This class specifies the theme color, stored in the document's Theme part to which the value of this theme color shall be mapped. 
/// This mapping enables multiple theme colors to be chained together.
/// </summary>
[DataContract]
public partial class ColorSchemeMapping : ModelElement<DXW.ColorSchemeMapping>
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
  public ColorSchemeMapping(): base(){ }

  public ColorSchemeMapping(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }

  public ColorSchemeMapping(DXW.ColorSchemeMapping openXmlElement): base(openXmlElement) { }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

  /// <summary>
  /// Background 1 Theme Color Mapping
  /// </summary>
  [DataMember]
  public DMW.ColorSchemeIndexKind? Background1
  {
    get => _Element?.Background1?.GetEnumValue<DMW.ColorSchemeIndexKind, DXW.ColorSchemeIndexValues>();
    set => EVU.SetEnumValue<DMW.ColorSchemeIndexKind, DXW.ColorSchemeIndexValues>(_ExistingElement, nameof(Background1), value);
  }

  /// <summary>
  /// Text 1 Theme Color Mapping
  /// </summary>
  [DataMember]
  public DMW.ColorSchemeIndexKind? Text1
  {
    get => _Element?.Text1?.GetEnumValue<DMW.ColorSchemeIndexKind, DXW.ColorSchemeIndexValues>();
    set => EVU.SetEnumValue<DMW.ColorSchemeIndexKind, DXW.ColorSchemeIndexValues>(_ExistingElement, nameof(Text1), value);
  }

  /// <summary>
  /// Background 2 Theme Color Mapping
  /// </summary>
  [DataMember]
  public DMW.ColorSchemeIndexKind? Background2
  {
    get => _Element?.Background2?.GetEnumValue<DMW.ColorSchemeIndexKind, DXW.ColorSchemeIndexValues>();
    set => EVU.SetEnumValue<DMW.ColorSchemeIndexKind, DXW.ColorSchemeIndexValues>(_ExistingElement, nameof(Background2), value);
  }

  /// <summary>
  /// Text 2 Theme Color Mapping
  /// </summary>
  [DataMember]
  public DMW.ColorSchemeIndexKind? Text2
  {
    get => _Element?.Text2?.GetEnumValue<DMW.ColorSchemeIndexKind, DXW.ColorSchemeIndexValues>();
    set => EVU.SetEnumValue<DMW.ColorSchemeIndexKind, DXW.ColorSchemeIndexValues>(_ExistingElement, nameof(Text2), value);
  }

  /// <summary>
  /// Accent 1 Theme Color Mapping
  /// </summary>
  [DataMember]
  public DMW.ColorSchemeIndexKind? Accent1
  {
    get => _Element?.Accent1?.GetEnumValue<DMW.ColorSchemeIndexKind, DXW.ColorSchemeIndexValues>();
    set => EVU.SetEnumValue<DMW.ColorSchemeIndexKind, DXW.ColorSchemeIndexValues>(_ExistingElement, nameof(Accent1), value);
  }

  /// <summary>
  /// Accent 2 Theme Color Mapping
  /// </summary>
  [DataMember]
  public DMW.ColorSchemeIndexKind? Accent2
  {
    get => _Element?.Accent2?.GetEnumValue<DMW.ColorSchemeIndexKind, DXW.ColorSchemeIndexValues>();
    set => EVU.SetEnumValue<DMW.ColorSchemeIndexKind, DXW.ColorSchemeIndexValues>(_ExistingElement, nameof(Accent2), value);
  }

  /// <summary>
  /// Accent3 Theme Color Mapping
  /// </summary>
  [DataMember]
  public DMW.ColorSchemeIndexKind? Accent3
  {
    get => _Element?.Accent3?.GetEnumValue<DMW.ColorSchemeIndexKind, DXW.ColorSchemeIndexValues>();
    set => EVU.SetEnumValue<DMW.ColorSchemeIndexKind, DXW.ColorSchemeIndexValues>(_ExistingElement, nameof(Accent3), value);
  }

  /// <summary>
  /// Accent4 Theme Color Mapping
  /// </summary>
  [DataMember]
  public DMW.ColorSchemeIndexKind? Accent4
  {
    get => _Element?.Accent4?.GetEnumValue<DMW.ColorSchemeIndexKind, DXW.ColorSchemeIndexValues>();
    set => EVU.SetEnumValue<DMW.ColorSchemeIndexKind, DXW.ColorSchemeIndexValues>(_ExistingElement, nameof(Accent4), value);
  }

  /// <summary>
  /// Accent5 Theme Color Mapping
  /// </summary>
  [DataMember]
  public DMW.ColorSchemeIndexKind? Accent5
  {
    get => _Element?.Accent5?.GetEnumValue<DMW.ColorSchemeIndexKind, DXW.ColorSchemeIndexValues>();
    set => EVU.SetEnumValue<DMW.ColorSchemeIndexKind, DXW.ColorSchemeIndexValues>(_ExistingElement, nameof(Accent5), value);
  }

  /// <summary>
  /// Accent6 Theme Color Mapping
  /// </summary>
  [DataMember]
  public DMW.ColorSchemeIndexKind? Accent6
  {
    get => _Element?.Accent6?.GetEnumValue<DMW.ColorSchemeIndexKind, DXW.ColorSchemeIndexValues>();
    set => EVU.SetEnumValue<DMW.ColorSchemeIndexKind, DXW.ColorSchemeIndexValues>(_ExistingElement, nameof(Accent6), value);
  }

  /// <summary>
  /// Hyperlink Theme Color Mapping
  /// </summary>
  [DataMember]
  public DMW.ColorSchemeIndexKind? Hyperlink
  {
    get => _Element?.Hyperlink?.GetEnumValue<DMW.ColorSchemeIndexKind, DXW.ColorSchemeIndexValues>();
    set => EVU.SetEnumValue<DMW.ColorSchemeIndexKind, DXW.ColorSchemeIndexValues>(_ExistingElement, nameof(Hyperlink), value);
  }

  /// <summary>
  /// Followed Hyperlink Theme Color Mapping
  /// </summary>
  [DataMember]
  public DMW.ColorSchemeIndexKind? FollowedHyperlink
  {
    get => _Element?.FollowedHyperlink?.GetEnumValue<DMW.ColorSchemeIndexKind, DXW.ColorSchemeIndexValues>();
    set => EVU.SetEnumValue<DMW.ColorSchemeIndexKind, DXW.ColorSchemeIndexValues>(_ExistingElement, nameof(FollowedHyperlink), value);
  }

}
