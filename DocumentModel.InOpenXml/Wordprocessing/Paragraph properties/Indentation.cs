namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the indentation settings for a paragraph in a WordprocessingML document.
/// This class provides properties for configuring left, right, start, and end indentation, as well as first line and hanging indentation, in both point and character units. Enables advanced control over paragraph layout and text alignment.
/// </summary>
public partial class Indentation : ModelElement<DXW.Indentation>
{
    /// <summary>
    /// Left indentation of the paragraph, specified in twentieths of a point.
    /// </summary>
    public string? Left { get => _Left; set => UpdateField(ref _Left, value, nameof(Left)); }

    private string? _Left;
    /// <summary>
    /// Start indentation of the paragraph, used for bidirectional text, specified in twentieths of a point.
    /// </summary>
    public string? Start { get; set; }
    /// <summary>
    /// Left indentation in character units.
    /// </summary>
    public Int32? LeftChars { get; set; }
    /// <summary>
    /// Start indentation in character units, used for bidirectional text.
    /// </summary>
    public Int32? StartCharacters { get; set; }
    /// <summary>
    /// Right indentation of the paragraph, specified in twentieths of a point.
    /// </summary>
    public string? Right { get; set; }
    /// <summary>
    /// End indentation of the paragraph, used for bidirectional text, specified in twentieths of a point.
    /// </summary>
    public string? End { get; set; }
    /// <summary>
    /// Right indentation in character units.
    /// </summary>
    public Int32? RightChars { get; set; }
    /// <summary>
    /// End indentation in character units, used for bidirectional text.
    /// </summary>
    public Int32? EndCharacters { get; set; }
    /// <summary>
    /// Hanging indentation, specifying the amount of indentation removed from the first line, in twentieths of a point.
    /// </summary>
    public string? Hanging { get; set; }
    /// <summary>
    /// Hanging indentation in character units, specifying the amount of indentation removed from the first line.
    /// </summary>
    public Int32? HangingChars { get; set; }
    /// <summary>
    /// Additional first line indentation, specifying the amount of extra indentation for the first line, in twentieths of a point.
    /// </summary>
    public string? FirstLine { get; set; }
    /// <summary>
    /// Additional first line indentation in character units.
    /// </summary>
    public Int32? FirstLineChars { get; set; }
}