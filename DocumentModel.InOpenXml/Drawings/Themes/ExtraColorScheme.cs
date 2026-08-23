namespace DocumentModel.Drawings;

/// <summary>
///   Represents an extra color scheme, including a color scheme definition and an associated color map.
/// </summary>
[OpenXmlType(typeof(DXD.ExtraColorScheme))]
[DataContract]
[XmlRoot("ExtraColorScheme", Namespace = "DocumentModel.Drawings")]
public partial class ExtraColorScheme: ModelElement<DXD.ExtraColorScheme>
{
  /// <summary>
  ///   Color scheme definition for the extra color scheme.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.ExtraColorScheme.ColorScheme))]
  public ColorScheme? ColorScheme
  {
    get => _ColorScheme ??= GetProperty<ColorScheme?>(GetUpdatableElement()?.ColorScheme);
    set => UpdateField(ref _ColorScheme, value, nameof(ColorScheme));
  }

  private ColorScheme? _ColorScheme;

  /// <summary>
  ///   Color map associated with the extra color scheme.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.ExtraColorScheme.ColorMap))]
  public ColorMap? ColorMap
  {
    get => _ColorMap ??= GetProperty<ColorMap?>(GetUpdatableElement()?.ColorMap);
    set => UpdateField(ref _ColorMap, value, nameof(ColorMap));
  }

  private ColorMap? _ColorMap;
}