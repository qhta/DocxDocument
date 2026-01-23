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
    public string? Start { get => _Start; set => UpdateField(ref _Start, value, nameof(Start)); }

    private string? _Start;
    /// <summary>
    /// Left indentation in character units.
    /// </summary>
    public Int32? LeftChars { get => _LeftChars; set => UpdateField(ref _LeftChars, value, nameof(LeftChars)); }

    private Int32? _LeftChars;
    /// <summary>
    /// Start indentation in character units, used for bidirectional text.
    /// </summary>
    public Int32? StartCharacters { get => _StartCharacters; set => UpdateField(ref _StartCharacters, value, nameof(StartCharacters)); }

    private Int32? _StartCharacters;
    /// <summary>
    /// Right indentation of the paragraph, specified in twentieths of a point.
    /// </summary>
    public string? Right { get => _Right; set => UpdateField(ref _Right, value, nameof(Right)); }

    private string? _Right;
    /// <summary>
    /// End indentation of the paragraph, used for bidirectional text, specified in twentieths of a point.
    /// </summary>
    public string? End { get => _End; set => UpdateField(ref _End, value, nameof(End)); }

    private string? _End;
    /// <summary>
    /// Right indentation in character units.
    /// </summary>
    public Int32? RightChars { get => _RightChars; set => UpdateField(ref _RightChars, value, nameof(RightChars)); }

    private Int32? _RightChars;
    /// <summary>
    /// End indentation in character units, used for bidirectional text.
    /// </summary>
    public Int32? EndCharacters { get => _EndCharacters; set => UpdateField(ref _EndCharacters, value, nameof(EndCharacters)); }

    private Int32? _EndCharacters;
    /// <summary>
    /// Hanging indentation, specifying the amount of indentation removed from the first line, in twentieths of a point.
    /// </summary>
    public string? Hanging { get => _Hanging; set => UpdateField(ref _Hanging, value, nameof(Hanging)); }

    private string? _Hanging;
    /// <summary>
    /// Hanging indentation in character units, specifying the amount of indentation removed from the first line.
    /// </summary>
    public Int32? HangingChars { get => _HangingChars; set => UpdateField(ref _HangingChars, value, nameof(HangingChars)); }

    private Int32? _HangingChars;
    /// <summary>
    /// Additional first line indentation, specifying the amount of extra indentation for the first line, in twentieths of a point.
    /// </summary>
    public string? FirstLine { get => _FirstLine; set => UpdateField(ref _FirstLine, value, nameof(FirstLine)); }

    private string? _FirstLine;
    /// <summary>
    /// Additional first line indentation in character units.
    /// </summary>
    public Int32? FirstLineChars { get => _FirstLineChars; set => UpdateField(ref _FirstLineChars, value, nameof(FirstLineChars)); }

    private Int32? _FirstLineChars;
}