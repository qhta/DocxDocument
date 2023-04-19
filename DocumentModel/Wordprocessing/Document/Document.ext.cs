namespace DocumentModel.Wordprocessing;

/// <summary>
///   Definition of model properties.
/// </summary>
public partial class Document
{
  /// <summary>
  /// Compound of object of document properties
  /// </summary>
  public DocumentProperties? Properties { get; set; }

  public Styles? Styles { get; set; }

  public DMDraws.Theme? Theme { get; set; }

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

  public EmbedFontData? EmbeddedFonts { get; set; }

  public Numbering? Numbering { get; set; }

  public DocComments? Comments { get; set; }

}