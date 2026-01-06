namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents a style (paragraph style, character style, etc.) in the document.
/// </summary>
public interface Style
{
  /// <summary>
  ///   Gets the name of the style.
  /// </summary>
  public string? NameLocal { get; }

  /// <summary>
  ///   Gets the built-in style identifier.
  /// </summary>
  public BuiltInStyleKind? BuiltIn { get; }

  /// <summary>
  ///   Gets the type of style.
  /// </summary>
  public StyleKind? Type { get; }

  /// <summary>
  ///   Gets the base style on which this style is based.
  /// </summary>
  public Style? BaseStyle { get; }

  /// <summary>
  ///   Gets the next paragraph style.
  /// </summary>
  public Style? NextParagraphStyle { get; }

  /// <summary>
  ///   Gets or sets whether the style is automatically updated.
  /// </summary>
  public bool? AutomaticallyUpdate { get; set; }

  /// <summary>
  ///   Gets or sets whether the style is hidden.
  /// </summary>
  public bool? Hidden { get; set; }

  /// <summary>
  ///   Gets the paragraph format for the style.
  /// </summary>
  public ParagraphFormat? ParagraphFormat { get; }

  /// <summary>
  ///   Gets the font properties for the style.
  /// </summary>
  public TextFormat? Font { get; }

  /// <summary>
  ///   Gets the parent application.
  /// </summary>
  public Application? Application { get; }
}