namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents line spacing settings for a paragraph in a WordprocessingML document.
/// This class provides properties for specifying spacing in twentieths of a point, line units, and automatic spacing, enabling advanced control over paragraph layout and readability.
/// </summary>
public abstract partial class SpacingBeforeOrAfter: ModelElement //<DXW.SpacingBeforeOrAfter>
{
  /// <summary>
  /// Spacing specified in twentieths of a point.
  /// </summary>
  public Twips? Val { get => _Val; set => UpdateField(ref _Val, value, nameof(Val)); }

  private Twips? _Val;

  /// <summary>
  /// Spacing between lines, specified in line units.
  /// </summary>
  public Int32? Lines { get => _Lines; set => UpdateField(ref _Lines, value, nameof(Lines)); }

  private Int32? _Lines;

  /// <summary>
  /// Indicates whether spacing is determined automatically.
  /// </summary>
  public bool? AutoSpacing { get => _AutoSpacing; set => UpdateField(ref _AutoSpacing, value, nameof(AutoSpacing)); }

  private bool? _AutoSpacing;

  /// <summary>
  /// Loads spacing settings from the provided source values,
  /// allowing for the creation of a SpacingBeforeOrAfter instance based on existing document properties.
  /// </summary>
  /// <param name="sourceVal">The source value for the spacing before the paragraph.</param>
  /// <param name="sourceLines">The source value for the line spacing before the paragraph.</param>
  /// <param name="sourceAutoSpacing">The source value for the automatic spacing before the paragraph.</param>
  /// <returns>A new instance of SpacingBeforeOrAfter with the specified settings.</returns>
  public void Init
    (DX.StringValue? sourceVal, DX.Int32Value? sourceLines, DX.OnOffValue? sourceAutoSpacing)
  {
    Val = (sourceVal?.Value) != null ? new Twips(sourceVal.Value) : null;
    Lines = sourceLines?.Value;
    AutoSpacing = sourceAutoSpacing?.Value;
  }
}