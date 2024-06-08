namespace DocumentModel.Wordprocessing;

using P = DocumentFormat.OpenXml.Packaging;
using W = DocumentFormat.OpenXml.Wordprocessing; 

/// <summary>
///   Compound document model.
/// </summary>
public partial class Document: IDisposable
{
  /// <summary>
  /// Internal WordprocessingDocument. Must be opened all the time.
  /// </summary>
  private P.WordprocessingDocument? WordprocessingDocument { get; set; } = null;

  /// <summary>
  /// Name of the opened file.
  /// </summary>
  public string? Filename { get; private set; }

  /// <summary>
  /// Opens internal Wordprocessing document from a file.
  /// </summary>
  /// <param name="filename">Full Filename</param>
  /// <param name="readWrite">Open for modification</param>
  public void Open(string filename, bool readWrite = true)
  {
    Filename = filename;
    WordprocessingDocument = P.WordprocessingDocument.Open(filename, readWrite);
  }

  /// <summary>
  /// Closes opened WordprocessingDocument.
  /// </summary>
  public void Close()
  {
    WordprocessingDocument?.Dispose();
    WordprocessingDocument = null!;
  }

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
  public DMD.Theme? Theme
  { 
    get => _Theme; 
    set
    {
      _Theme = value;
      if (_Theme != null)
        _Theme.Parent = this;
    }
  }
  private DMD.Theme? _Theme;

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
  public Numbering? Numbering 
  { 
    get => _Numbering; 
    set
    {
      _Numbering = value;
      if (_Numbering != null)
        _Numbering.Parent = this;
    }
  }
  private Numbering? _Numbering;

  /// <summary>
  /// Comment annotations.
  /// </summary>
  public DocComments? Comments
  { 
    get => _Comments; 
    set
    {
      _Comments = value;
      if (_Comments != null)
        _Comments.Parent = this;
    }
  }
  private DocComments? _Comments;


  /// <summary>
  /// Document background.
  /// </summary>
  public DocumentBackground? Background
  { 
    get => _Background; 
    set
    {
      _Background = value;
      if (_Background != null)
        _Background.Parent = this;
    }
  }
  private DocumentBackground? _Background;
  private bool disposedValue;

  protected virtual void Dispose(bool disposing)
  {
    if (!disposedValue)
    {
      if (disposing)
      {
        WordprocessingDocument?.Dispose();
      }

      // TODO: free unmanaged resources (unmanaged objects) and override finalizer
      // TODO: set large fields to null
      disposedValue = true;
    }
  }

  // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
  // ~Document()
  // {
  //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
  //     Dispose(disposing: false);
  // }

  public void Dispose()
  {
    // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
    Dispose(disposing: true);
    GC.SuppressFinalize(this);
  }
}