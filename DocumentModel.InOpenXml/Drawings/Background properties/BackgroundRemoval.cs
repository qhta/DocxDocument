namespace DocumentModel.Drawings;
/// <summary>
/// Represents background removal properties, including marquee boundaries and collections of foreground and background marks for image processing.
/// </summary>
public partial class BackgroundRemoval : ModelElement<DXO10D.BackgroundRemoval>
{
    /// <summary>
    /// Gets or sets the top boundary of the marquee used for background removal.
    /// </summary>
    [OpenXmlProperty(nameof(DXO10D.BackgroundRemoval.MarqueeTop))]
    /// <summary>
    /// Gets or sets the top boundary of the marquee used for background removal.
    /// </summary>
    [OpenXmlElement(typeof(DXO10D.BackgroundRemoval))]
    public Int32? MarqueeTop { get => _MarqueeTop; set => UpdateField(ref _MarqueeTop, value, nameof(MarqueeTop)); }

    private Int32? _MarqueeTop;
    /// <summary>
    /// Gets or sets the bottom boundary of the marquee used for background removal.
    /// </summary>
    [OpenXmlProperty(nameof(DXO10D.BackgroundRemoval.MarqueeBottom))]
    /// <summary>
    /// Gets or sets the bottom boundary of the marquee used for background removal.
    /// </summary>
    [OpenXmlElement(typeof(DXO10D.BackgroundRemoval))]
    public Int32? MarqueeBottom { get => _MarqueeBottom; set => UpdateField(ref _MarqueeBottom, value, nameof(MarqueeBottom)); }

    private Int32? _MarqueeBottom;
    /// <summary>
    /// Gets or sets the left boundary of the marquee used for background removal.
    /// </summary>
    [OpenXmlProperty(nameof(DXO10D.BackgroundRemoval.MarqueeLeft))]
    /// <summary>
    /// Gets or sets the left boundary of the marquee used for background removal.
    /// </summary>
    [OpenXmlElement(typeof(DXO10D.BackgroundRemoval))]
    public Int32? MarqueeLeft { get => _MarqueeLeft; set => UpdateField(ref _MarqueeLeft, value, nameof(MarqueeLeft)); }

    private Int32? _MarqueeLeft;
    /// <summary>
    /// Gets or sets the right boundary of the marquee used for background removal.
    /// </summary>
    [OpenXmlProperty(nameof(DXO10D.BackgroundRemoval.MarqueeRight))]
    /// <summary>
    /// Gets or sets the right boundary of the marquee used for background removal.
    /// </summary>
    [OpenXmlElement(typeof(DXO10D.BackgroundRemoval))]
    public Int32? MarqueeRight { get => _MarqueeRight; set => UpdateField(ref _MarqueeRight, value, nameof(MarqueeRight)); }

    private Int32? _MarqueeRight;
    /// <summary>
    /// Gets or sets the collection of foreground marks, which indicate areas to retain during background removal.
    /// </summary>
    [OpenXmlElement(typeof(DXO10D.BackgroundRemoval))]
    public ForegroundMarks? ForegroundMarks { get => _ForegroundMarks; set => UpdateField(ref _ForegroundMarks, value, nameof(ForegroundMarks)); }

    private ForegroundMarks? _ForegroundMarks;
    /// <summary>
    /// Gets or sets the collection of background marks, which indicate areas to remove during background removal.
    /// </summary>
    [OpenXmlElement(typeof(DXO10D.BackgroundRemoval))]
    public BackgroundMarks? BackgroundMarks { get => _BackgroundMarks; set => UpdateField(ref _BackgroundMarks, value, nameof(BackgroundMarks)); }

    private BackgroundMarks? _BackgroundMarks;
}