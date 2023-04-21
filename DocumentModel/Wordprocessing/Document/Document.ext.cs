namespace DocumentModel.Wordprocessing;

/// <summary>
///   Compound document model.
/// </summary>
public partial class Document
{
  /// <summary>
  /// Compound of object of document properties
  /// </summary>
  public DocumentProperties? Properties { get; set; }

  /// <summary>
  /// Style definitions.
  /// </summary>
  public Styles? Styles 
  { 
    get => _Styles; 
    set
    {
      _Styles = value;
      if (_Styles != null)
        _Styles.Parent = this;
    }
  }
  private Styles? _Styles;

  /// <summary>
  /// Set if color and font themes.
  /// </summary>
  public DMDraws.Theme? Theme
  { 
    get => _Theme; 
    set
    {
      _Theme = value;
      if (_Theme != null)
        _Theme.Parent = this;
    }
  }
  private DMDraws.Theme? _Theme;

  /// <summary>
  /// Font table
  /// </summary>
  public Fonts? Fonts 
  { 
    get => _Fonts; 
    set
    {
      _Fonts = value;
      if (_Fonts != null)
        _Fonts.Parent = this;
    }
  }
  private Fonts? _Fonts;

  /// <summary>
  /// Collection of embedded fonts data.
  /// </summary>
  public EmbedFontData? EmbeddedFonts { get; set; }

  /// <summary>
  /// Numbering definitions.
  /// </summary>
  public Numbering? Numbering { get; set; }

  /// <summary>
  /// Comment annotations.
  /// </summary>
  public DocComments? Comments { get; set; }

}