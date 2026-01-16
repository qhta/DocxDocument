namespace DocumentModel;

/// <summary>
///   This set of properties is evaluated on document change.
/// </summary>
public class StatisticProperties: ModelElement<DXEP.Properties>
{

  /// <summary>
  /// Gets the underlying WordprocessingDocument instance associated with this object.
  /// </summary>
  internal DXPP.WordprocessingDocument? WordprocessingDocument { get; private set; }


  /// <summary>
  /// Default constructor.
  /// </summary>
  public StatisticProperties()
  {
  }

  /// <summary>
  /// Initializing constructor.
  /// </summary>
  /// <param name="document">Wordprocessing document model</param>
  public StatisticProperties(Wordprocessing.Document document)
  {
    AttachAndLoad(document);
  }

  /// <summary>
  /// Attach this instance to the specified document. Data is loaded from the document's PackageProperties.
  /// </summary>
  /// <param name="document">Document to attach to.</param>
  public void AttachAndLoad(Wordprocessing.Document document)
  {
    WordprocessingDocument = document.WordprocessingDocument;
    var extendedFileProperties = document.WordprocessingDocument?.GetExtendedFileProperties();
    if (extendedFileProperties != null)
    {
      SetOpenXmlElement(extendedFileProperties);
      LoadData(extendedFileProperties);
    }
  }

  /// <summary>
  /// Attach this instance to the specified document. Data is stored to the document's PackageProperties.
  /// </summary>
  /// <param name="document">Document to attach to.</param>
  public void AttachAndUpdate(Wordprocessing.Document document)
  {
    WordprocessingDocument = document.WordprocessingDocument;
    var extendedFileProperties = document.WordprocessingDocument?.GetExtendedFileProperties();
    if (extendedFileProperties != null)
    {
      SetOpenXmlElement(extendedFileProperties);
      UpdateData(extendedFileProperties);
    }
  }

  /// <summary>
  /// Detach this instance from the specified document.
  /// Underlying Open XML element is set to null, so further access to its properties will not work until re-attached.
  /// </summary>
  /// <param name="document">Document to detach from. Must be the same as the one attached.</param>
  public void Detach(Wordprocessing.Document document)
  {
    if (WordprocessingDocument != document.WordprocessingDocument)
      return;
    WordprocessingDocument = null;
    SetOpenXmlElement(null);
  }




  /// <summary>
  /// Known properties that can be set in StatisticProperties
  /// </summary>
  public static KnownProperties KnownProperties { get; } = new KnownProperties(typeof(StatisticProperties));

  /// <summary>
  ///   The total number of pages of a document if applicable.
  /// </summary>
  public int? Pages
  {
    get => _Pages;
    set => UpdateField(ref _Pages, value, nameof(Pages));
  }
  private int? _Pages;

  /// <summary>
  ///   The total number of words of a document if applicable.
  /// </summary>
  public int? Words
  {
    get => _Words;
    set => UpdateField(ref _Words, value, nameof(Words));
  }
  private int? _Words;

  /// <summary>
  ///   The total number of characters in a document.
  /// </summary>
  public int? Characters
  {
    get => _Characters;
    set => UpdateField(ref _Characters, value, nameof(Characters));
  }
  private int? _Characters;

  /// <summary>
  ///   The total number of lines in a document when last saved by a conforming producer if applicable.
  /// </summary>
  public int? Lines
  {
    get => _Lines;
    set => UpdateField(ref _Lines, value, nameof(Lines));
  }
  private int? _Lines;

  /// <summary>
  ///   The total number of paragraphs found in a document if applicable.
  /// </summary>
  public int? Paragraphs
  {
    get => _Paragraphs;
    set => UpdateField(ref _Paragraphs, value, nameof(Paragraphs));
  }
  private int? _Paragraphs;

  /// <summary>
  ///   The last count of the number of characters (including spaces) in this document.
  /// </summary>
  public int? CharactersWithSpaces
  {
    get => _CharactersWithSpaces;
    set => UpdateField(ref _CharactersWithSpaces, value, nameof(CharactersWithSpaces));
  }
  private int? _CharactersWithSpaces;

  /// <summary>
  ///  The total number of slides in a presentation document.
  /// </summary>
  public int? Slides
  {
    get => _Slides;
    set => UpdateField(ref _Slides, value, nameof(Slides));
  }
  private int? _Slides;

  /// <summary>
  ///  The number of slides in a presentation containing notes.
  /// </summary>
  public int? Notes
  {
    get => _Notes;
    set => UpdateField(ref _Notes, value, nameof(Notes));
  }
  private int? _Notes;

  /// <summary>
  ///   The number of hidden slides in a presentation document.
  /// </summary>
  public int? HiddenSlides
  {
    get => _HiddenSlides;
    set => UpdateField(ref _HiddenSlides, value, nameof(HiddenSlides));
  }
  private int? _HiddenSlides;

  /// <summary>
  ///   The total number of sound or video clips that are present in the document.
  /// </summary>
  public int? MultimediaClips
  {
    get => _MultimediaClips;
    set => UpdateField(ref _MultimediaClips, value, nameof(MultimediaClips));
  }
  private int? _MultimediaClips;

  /// <summary>
  ///   Total time that a document has been edited. The default time unit is minutes.
  /// </summary>
  [Unit("min")]
  public int? TotalTime
  {
    get => _TotalTime;
    set => UpdateField(ref _TotalTime, value, nameof(TotalTime));
  }
  private int? _TotalTime;

}