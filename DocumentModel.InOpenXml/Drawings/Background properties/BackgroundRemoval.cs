namespace DocumentModel.Drawings;
/// <summary>
/// Represents background removal properties, including marquee boundaries and collections of foreground and background marks for image processing.
/// </summary>
public partial class BackgroundRemoval : ModelElement<DXO10D.BackgroundRemoval>
{
    /// <summary>
    /// Gets or sets the top boundary of the marquee used for background removal.
    /// </summary>
    public Int32? MarqueeTop { get => _MarqueeTop; set => UpdateField(ref _MarqueeTop, value, nameof(MarqueeTop)); }

    private Int32? _MarqueeTop;
    /// <summary>
    /// Gets or sets the bottom boundary of the marquee used for background removal.
    /// </summary>
    public Int32? MarqueeBottom { get; set; }
    /// <summary>
    /// Gets or sets the left boundary of the marquee used for background removal.
    /// </summary>
    public Int32? MarqueeLeft { get; set; }
    /// <summary>
    /// Gets or sets the right boundary of the marquee used for background removal.
    /// </summary>
    public Int32? MarqueeRight { get; set; }
    /// <summary>
    /// Gets or sets the collection of foreground marks, which indicate areas to retain during background removal.
    /// </summary>
    public ForegroundMarks? ForegroundMarks { get; set; }
    /// <summary>
    /// Gets or sets the collection of background marks, which indicate areas to remove during background removal.
    /// </summary>
    public BackgroundMarks? BackgroundMarks { get; set; }
}