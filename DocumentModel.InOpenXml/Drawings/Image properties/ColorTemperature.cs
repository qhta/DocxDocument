namespace DocumentModel.Drawings;
/// <summary>
/// Defines the color temperature effect for drawing elements.
/// </summary>
public partial class ColorTemperature : ModelElement<DXO10D.ColorTemperature>, IExtendableElement
{
    /// <summary>
    /// Color temperature value.
    /// </summary>
    [OpenXmlProperty(nameof(DXO10D.ColorTemperature.ColorTemperatureValue))]
    /// <summary>
    /// Color temperature value.
    /// </summary>
    [OpenXmlElement(typeof(DXO10D.ColorTemperature))]
    public Int32? ColorTemperatureValue { get => _ColorTemperatureValue; set => UpdateField(ref _ColorTemperatureValue, value, nameof(ColorTemperatureValue)); }

    private Int32? _ColorTemperatureValue;
    /// <summary>
    /// List of extensions for the color temperature effect.
    /// </summary>
    [OpenXmlElement(typeof(DXO10D.ColorTemperature))]
    public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }

    private ExtensionList? _ExtensionList;
}