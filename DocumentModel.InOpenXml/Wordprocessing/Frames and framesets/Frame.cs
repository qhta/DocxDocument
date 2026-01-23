namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the properties of a single frame in a WordprocessingML document.
/// This class extends <see cref = "IFramesetItem"/> and provides properties for frame size, name, source file, margins, scrollbar visibility, resize restrictions, and file linking, enabling advanced configuration and management of frames within framesets.
/// </summary>
public partial class Frame : ModelElement<DXW.Frame>, IFramesetItem
{
    /// <summary>
    /// Size of the frame, specified as a width or height value depending on the frameset orientation.
    /// </summary>
    public UInt32? FrameSize { get => _FrameSize; set => UpdateField(ref _FrameSize, value, nameof(FrameSize)); }

    private UInt32? _FrameSize;
    /// <summary>
    /// Name of the frame, used for identification and targeting within the frameset.
    /// </summary>
    public string? FrameName { get => _FrameName; set => UpdateField(ref _FrameName, value, nameof(FrameName)); }

    private string? _FrameName;
    /// <summary>
    /// Source file for the frame, specifying the external content to be displayed within the frame.
    /// </summary>
    public SourceReference? SourceFileReference { get => _SourceFileReference; set => UpdateField(ref _SourceFileReference, value, nameof(SourceFileReference)); }

    private SourceReference? _SourceFileReference;
    /// <summary>
    /// Left and right margin for the frame, specified in pixels.
    /// </summary>
    public UInt32? MarginWidth { get => _MarginWidth; set => UpdateField(ref _MarginWidth, value, nameof(MarginWidth)); }

    private UInt32? _MarginWidth;
    /// <summary>
    /// Top and bottom margin for the frame, specified in pixels.
    /// </summary>
    public UInt32? MarginHeight { get => _MarginHeight; set => UpdateField(ref _MarginHeight, value, nameof(MarginHeight)); }

    private UInt32? _MarginHeight;
    /// <summary>
    /// Scrollbar display option for the frame, specifying visibility and behavior of scrollbars.
    /// </summary>
    public FrameScrollbarVisibilityKind? ScrollbarVisibility { get => _ScrollbarVisibility; set => UpdateField(ref _ScrollbarVisibility, value, nameof(ScrollbarVisibility)); }

    private FrameScrollbarVisibilityKind? _ScrollbarVisibility;
    /// <summary>
    /// Indicates whether the frame cannot be resized by the user.
    /// </summary>
    public bool? NoResizeAllowed { get => _NoResizeAllowed; set => UpdateField(ref _NoResizeAllowed, value, nameof(NoResizeAllowed)); }

    private bool? _NoResizeAllowed;
    /// <summary>
    /// Indicates whether the frame maintains a link to an existing external file.
    /// </summary>
    public bool? LinkedToFile { get => _LinkedToFile; set => UpdateField(ref _LinkedToFile, value, nameof(LinkedToFile)); }

    private bool? _LinkedToFile;
}