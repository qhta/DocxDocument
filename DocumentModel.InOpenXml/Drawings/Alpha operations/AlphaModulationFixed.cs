namespace DocumentModel.Drawings;
/// <summary>
/// Represents an alpha modulation effect with a fixed amount, used to adjust the transparency of an image or shape.
/// </summary>
public partial class AlphaModulationFixed : ModelElement<DXD.AlphaModulationFixed>
{
    /// <summary>
    /// Fixed amount by which the alpha channel is modulated.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.AlphaModulationFixed.Amount))]
    /// <summary>
    /// Fixed amount by which the alpha channel is modulated.
    /// </summary>
    [OpenXmlElement(typeof(DXD.AlphaModulationFixed))]
    public Int32? Amount { get => _Amount; set => UpdateField(ref _Amount, value, nameof(Amount)); }

    private Int32? _Amount;
}