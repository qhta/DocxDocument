namespace DocumentModel.Drawings;

/// <summary>
/// Represents an alpha replace effect, which sets the alpha channel of an image or shape to a specified value.
/// </summary>
[OpenXmlType(typeof(DXD.AlphaReplace))]
[DataContract]
[XmlRoot("AlphaReplace", Namespace = "DocumentModel.Drawings")]
public partial class AlphaReplace : ModelElement<DXD.AlphaReplace>
{
  /// <summary>
  /// Alpha value to be applied, replacing the existing alpha channel.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.AlphaReplace.Alpha))]
  public Int32? Alpha
  {
    get => _Alpha ??= GetProperty<Int32?>(GetUpdatableElement()?.Alpha);
    set => UpdateField(ref _Alpha, value, nameof(Alpha));
  }

  private Int32? _Alpha;
}