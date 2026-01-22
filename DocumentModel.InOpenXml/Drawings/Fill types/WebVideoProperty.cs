namespace DocumentModel.Drawings;
/// <summary>
/// Represents properties for an embedded web video, including HTML markup and display dimensions.
/// </summary>
public partial class WebVideoProperty : ModelElement
{
    /// <summary>
    /// Gets or sets the embedded HTML markup used to render the web video.
    /// </summary>
    public string? EmbeddedHtml { get => _EmbeddedHtml; set => UpdateField(ref _EmbeddedHtml, value, nameof(EmbeddedHtml)); }

    private string? _EmbeddedHtml;
    /// <summary>
    /// Gets or sets the height of the web video display area, in pixels.
    /// </summary>
    public UInt32? Height { get; set; }
    /// <summary>
    /// Gets or sets the width of the web video display area, in pixels.
    /// </summary>
    public UInt32? Width { get; set; }
}