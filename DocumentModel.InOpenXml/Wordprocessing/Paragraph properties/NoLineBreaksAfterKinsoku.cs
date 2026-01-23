namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a custom set of characters that cannot end a line in a WordprocessingML document.
/// This class provides properties for specifying the language and the set of restricted characters, enabling advanced control over line breaking and kinsoku shori rules for East Asian and other scripts.
/// </summary>
public partial class NoLineBreaksAfterKinsoku : ModelElement<DXW.NoLineBreaksAfterKinsoku>
{
    /// <summary>
    /// Language code for which the kinsoku rule applies, specifying the script or locale.
    /// </summary>
    [OpenXmlProperty(nameof(DXW.NoLineBreaksAfterKinsoku.Language))]
    /// <summary>
    /// Language code for which the kinsoku rule applies, specifying the script or locale.
    /// </summary>
    [OpenXmlElement(typeof(DXW.NoLineBreaksAfterKinsoku))]
    public string? Language { get => _Language; set => UpdateField(ref _Language, value, nameof(Language)); }

    private string? _Language;
    /// <summary>
    /// Set of characters that cannot end a line, specified as a string of restricted characters.
    /// </summary>
    [OpenXmlProperty(nameof(DXW.NoLineBreaksAfterKinsoku.Val))]
    /// <summary>
    /// Set of characters that cannot end a line, specified as a string of restricted characters.
    /// </summary>
    [OpenXmlElement(typeof(DXW.NoLineBreaksAfterKinsoku))]
    public string? Val { get => _Val; set => UpdateField(ref _Val, value, nameof(Val)); }

    private string? _Val;
}