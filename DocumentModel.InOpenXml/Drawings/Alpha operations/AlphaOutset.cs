namespace DocumentModel.Drawings;

/// <summary>
/// Represents an alpha inset or outset effect, which modifies the transparency of an image or shape based on a specified radius.
/// </summary>
[OpenXmlType(typeof(DXD.AlphaOutset))]
[DataContract]
[XmlRoot("AlphaOutset", Namespace = "DocumentModel.Drawings")]
public partial class AlphaOutset: ModelElement<DXD.AlphaOutset>
{
  /// <summary>
  /// Radius value that determines the extent of the alpha inset or outset effect.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.AlphaOutset.Radius))]
  public Int64? Radius
  {
    get => _Radius ??= GetProperty<Int64?>(GetUpdatableElement()?.Radius);
    set => UpdateField(ref _Radius, value, nameof(Radius));
  }

  private Int64? _Radius;
}