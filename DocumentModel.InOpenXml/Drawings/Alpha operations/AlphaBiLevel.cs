namespace DocumentModel.Drawings;
/// <summary>
/// Represents an alpha bi-level effect, which applies a threshold to the alpha channel of an image or shape.
/// </summary>
public partial class AlphaBiLevel : ModelElement<DXD.AlphaBiLevel>
{
    /// <summary>
    /// Threshold value used to determine the bi-level separation of the alpha channel.
    /// </summary>
    public Int32? Threshold { get => _Threshold; set => UpdateField(ref _Threshold, value, nameof(Threshold)); }

    private Int32? _Threshold;
}