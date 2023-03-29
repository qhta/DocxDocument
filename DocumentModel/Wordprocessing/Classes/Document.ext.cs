namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Document.
/// </summary>
public partial class Document
{
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

  public FontDataDictionary? EmbeddedFonts { get; set; }

  public Numbering? Numbering { get; set; }

}