namespace DocumentModel.Drawings;

/// <summary>
///   Represents a reference to a font, including its identifier and color information in various color models.
/// </summary>
[OpenXmlType(typeof(DXD.FontReference))]
[DataContract]
[XmlRoot("FontReference", Namespace = "DocumentModel.Drawings")]
public partial class FontReference: ModelElement<DXD.FontReference>
{
  /// <summary>
  ///   Identifier for the font collection index.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.FontReference.Index))]
  public FontCollectionIndex? Index
  {
    get => _Index ??= GetProperty<FontCollectionIndex?>(GetUpdatableElement()?.Index);
    set => UpdateField(ref _Index, value, nameof(Index));
  }

  private FontCollectionIndex? _Index;

  /// <summary>
  ///   Color specified using the RGB color model with percentage values.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.FontReference.RgbColorModelPercentage))]
  public ColorType? Color
  {
    get => _Color ??= GetProperty<ColorType?>(GetUpdatableElement()?.RgbColorModelPercentage);
    set => UpdateField(ref _Color, value, nameof(Color));
  }

  private ColorType? _Color;
}