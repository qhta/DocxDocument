namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the spacing settings between lines and paragraphs in a WordprocessingML document.
/// This class provides properties for configuring spacing above and below paragraphs, automatic spacing, line spacing, and line spacing rules, enabling advanced control over paragraph layout and readability.
/// </summary>
public partial class ParagraphSpacing : ModelElement
{
    /// <summary>
    /// Spacing above the paragraph.
    /// </summary>
    public SpacingBeforeOrAfter? Before { get => _Before; set => UpdateField(ref _Before, value, nameof(Before)); }

    private SpacingBeforeOrAfter? _Before;
    /// <summary>
    /// Spacing below the paragraph.
    /// </summary>
    public SpacingBeforeOrAfter? After { get => _After; set => UpdateField(ref _After, value, nameof(After)); }

    private SpacingBeforeOrAfter? _After;
    /// <summary>
    /// Spacing between lines within the paragraph.
    /// </summary>
    public SpacingBetween? Between { get => _Between; set => UpdateField(ref _Between, value, nameof(Between)); }

    private SpacingBetween? _Between;
}