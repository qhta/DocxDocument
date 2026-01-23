namespace DocumentModel.Drawings;
/// <summary>
/// Represents an alpha replace effect, which sets the alpha channel of an image or shape to a specified value.
/// </summary>
public partial class AlphaReplace : ModelElement<DXD.AlphaReplace>
{
    /// <summary>
    /// Alpha value to be applied, replacing the existing alpha channel.
    /// </summary>
    [OpenXmlProperty(nameof(DXD.AlphaReplace.Alpha))]
    public Int32? Alpha { get => _Alpha; set => UpdateField(ref _Alpha, value, nameof(Alpha)); }

    private Int32? _Alpha;
}