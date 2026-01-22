namespace DocumentModel.Drawings;
/// <summary>
///   Represents normal autofit settings for text, including font scaling and line space reduction.
/// </summary>
public partial class NormalAutoFit : ModelElement<DXD.NormalAutoFit>
{
    /// <summary>
    ///   Percentage scale applied to the font size for autofitting text.
    /// </summary>
    public Int32? FontScale { get => _FontScale; set => UpdateField(ref _FontScale, value, nameof(FontScale)); }

    private Int32? _FontScale;
    /// <summary>
    ///   Percentage reduction applied to line spacing for autofitting text.
    /// </summary>
    public Int32? LineSpaceReduction { get; set; }
}