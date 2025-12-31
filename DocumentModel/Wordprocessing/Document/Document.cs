namespace DocumentModel.Wordprocessing;


using P = DocumentFormat.OpenXml.Packaging;
using W = DocumentFormat.OpenXml.Wordprocessing;

/// <summary>
///   Main Document.
/// </summary>
public partial class Document : ModelElement, IDisposable
{

  /// <summary>
  /// Internal WordprocessingDocument. Must be opened all the time.
  /// </summary>
  internal P.WordprocessingDocument WordprocessingDocument { get; set; } = null!;

  /// <summary>
  /// Name of the opened file.
  /// </summary>
  public string? Filename
  {
    get; private set;
  }

  /// <summary>
  /// Opens internal Wordprocessing document from a file.
  /// </summary>
  /// <param name="filename">Full Filename</param>
  /// <param name="readWrite">Open for modification</param>
  public void Open(string filename, bool readWrite = true)
  {
    Filename = filename;
    WordprocessingDocument = P.WordprocessingDocument.Open(filename, readWrite);
    CoreProperties = new CoreProperties(this);
  }

  /// <summary>
  /// Closes opened WordprocessingDocument.
  /// </summary>
  public void Close()
  {
    WordprocessingDocument?.Dispose();
    WordprocessingDocument = null!;
  }

  #region CoreProperties
  internal CoreProperties CoreProperties { get; private set; } = null!;

  /// <summary>
  /// Title of the document.
  /// </summary>
  public string? Title
  {
    get => CoreProperties.Title; set => CoreProperties.Title = value;
  }

  /// <summary>
  /// First author of the document.
  /// </summary>
  public string? Author
  {
    get => CoreProperties.Creator; set => CoreProperties.Creator = value;
  }

  /// <summary>
  ///   Comma delimited set of keywords to support searching and indexing. 
  /// </summary>
  public string? Keywords
  {
    get => CoreProperties.Keywords; set => CoreProperties.Keywords = value;
  }

  /// <summary>
  ///   Short description of the document.
  /// </summary>
  public string? Description
  {
    get => CoreProperties.Description; set => CoreProperties.Description = value;
  }

  /// <summary>
  ///   The user who performed the last modification.
  /// </summary>
  public string? LastModifiedBy
  {
    get => CoreProperties.LastModifiedBy; set => CoreProperties.LastModifiedBy = value;
  }

  /// <summary>
  ///   The revision number.
  /// </summary>
  public int? Revision
  {
    get => CoreProperties.Revision; set => CoreProperties.Revision = value;
  }

  /// <summary>
  ///   The date and time of the last printing.
  /// </summary>
  public DateTime? LastPrinted
  {
    get => CoreProperties.LastPrinted; set => CoreProperties.LastPrinted = value;
  }

  /// <summary>
  ///   Date of creation of the resource.
  /// </summary>
  public DateTime? Created
  {
    get => CoreProperties.Created; set => CoreProperties.Created = value;
  }

  /// <summary>
  ///   The date and time of the last modification.
  /// </summary>
  public DateTime? Modified
  {
    get => CoreProperties.Modified; set => CoreProperties.Modified = value;
  }

  /// <summary>
  ///   A categorization of the content of the document. 
  /// </summary>
  public string? Category
  {
    get => CoreProperties.Category; set => CoreProperties.Category = value;
  }

  /// <summary>
  ///   An unambiguous reference to the document within a given context.
  /// </summary>
  public string? Identifier
  {
    get => CoreProperties.Identifier; set => CoreProperties.Identifier = value;
  }

  /// <summary>
  ///   The type of content document.
  /// </summary>
  public string? ContentType
  {
    get => CoreProperties.ContentType; set => CoreProperties.ContentType = value;
  }

  /// <summary>
  ///   Main language of the document.
  /// </summary>
  public string? Language
  {
    get => CoreProperties.Language; set => CoreProperties.Language = value;
  }

  /// <summary>
  ///   The version number. This value is set by the user or by the application.
  /// </summary>
  public string? Version
  {
    get => CoreProperties.Version; set => CoreProperties.Version = value;
  }

  /// <summary>
  ///   The status of the content.
  /// </summary>
  public string? ContentStatus
  {
    get => CoreProperties.ContentStatus; set => CoreProperties.ContentStatus = value;
  }
  #endregion

  /// <summary>
  /// Compound of object of document properties
  /// </summary>
  public DocumentProperties? Properties
  {
    get; set;
  }

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
  public EmbedFontData? EmbeddedFonts
  {
    get; set;
  }

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

  /// <summary>
  /// Needed as part of IDisposable pattern.
  /// </summary>
  /// <param name="disposing"></param>
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

  /// <summary>
  /// Needed as part of IDisposable pattern.
  /// </summary>
  public void Dispose()
  {
    // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
    Dispose(disposing: true);
    GC.SuppressFinalize(this);
  }
  /// <summary>
  ///   conformance
  /// </summary>
  public DocumentConformance? Conformance
  {
    get; set;
  }

  /// <summary>
  ///   Document Background.
  /// </summary>
  public DocumentBackground? DocumentBackground
  {
    get; set;
  }

  /// <summary>
  ///   Body.
  /// </summary>
  public Body? Body
  {
    get; set;
  }
}