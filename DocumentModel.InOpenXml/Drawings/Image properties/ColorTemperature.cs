namespace DocumentModel.Drawings;

/// <summary>
/// Defines the color temperature effect for drawing elements.
/// </summary>
[OpenXmlType(typeof(DXO10D.ColorTemperature))]
[DataContract]
[XmlRoot("ColorTemperature", Namespace = "DocumentModel.Drawings")]
public partial class ColorTemperature: ModelElement<DXO10D.ColorTemperature>, IExtendableElement
{
  /// <summary>
  /// Color temperature value.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10D.ColorTemperature.ColorTemperatureValue))]
  public Int32? ColorTemperatureValue
  {
    get => _ColorTemperatureValue ??= GetProperty<Int32?>(GetUpdatableElement()?.ColorTemperatureValue);
    set => UpdateField(ref _ColorTemperatureValue, value, nameof(ColorTemperatureValue));
  }

  private Int32? _ColorTemperatureValue;

  /// <summary>
  /// List of extensions for the color temperature effect.
  /// </summary>
  public ExtensionList? ExtensionList
  {
    get => _ExtensionList;
    set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList));
  }

  private ExtensionList? _ExtensionList;
}