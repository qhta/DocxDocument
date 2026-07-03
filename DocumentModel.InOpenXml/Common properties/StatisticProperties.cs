namespace DocumentModel;
/// <summary>
///   This set of properties is evaluated on document change.
/// </summary>
[OpenXmlType(typeof(DXEP.Properties))]
[DataContract]
[XmlRoot("StatisticProperties", Namespace = "DocumentModel")]
[DirectAccess]
public sealed partial class StatisticProperties : BaseBuiltInProperties
{
  /// <summary>
  /// Known properties that can be set in StatisticProperties
  /// </summary>
  public static KnownProperties KnownProperties
  {
    get
    {
      if (_KnownProperties == null)
        _KnownProperties = new KnownProperties(typeof(StatisticProperties));
      return _KnownProperties;
    }
  }
  private static KnownProperties? _KnownProperties;

  /// <summary>
  /// Default constructor.
  /// </summary>
  public StatisticProperties(): base(KnownProperties)
  {
  }

  /// <summary>
  /// Initializing constructor.
  /// </summary>
  /// <param name = "document">Wordprocessing document model</param>
  public StatisticProperties(Wordprocessing.Document document): this()
  {
    if (document.WordprocessingDocument != null)
      AttachAndLoad(document.WordprocessingDocument);
  }

  /// <summary>
  /// Represents the underlying Open XML element associated with this instance, or null if no element is present.
  /// </summary>
  private DXEP.Properties? OpenXmlProperties => (DXEP.Properties?)base.GetUpdatableObject();

  /// <summary>
  /// Retrieves the Open XML element that represents the updatable statistic properties for the current instance.
  /// </summary>
  /// <returns>An object representing the updatable Open XML statistic properties, or <see langword="null"/> if no properties are
  /// available.</returns>
  public override object? GetUpdatableObject()
  {
    if (WordprocessingDocument != null)
      return WordprocessingDocument.GetExtendedFileProperties(true);
    return null;
  }

  /// <summary>
  /// Attach this instance to the specified wordprocessingDocument.
  /// Data is loaded from the wordprocessingDocument's ExtendedFileProperties part.
  /// </summary>
  /// <param name = "wordprocessingDocument">Document to attach to.</param>
  public override void AttachAndLoad(DXPP.WordprocessingDocument wordprocessingDocument)
  {
    base.AttachAndLoad(wordprocessingDocument);
    var properties = wordprocessingDocument.GetExtendedFileProperties(true);
    if (properties != null)
    {
      SetUpdatableObject(properties);
      LoadData(properties);
    }
  }
  /// <summary>
  /// Copies data from the specified StatisticProperties instance to this instance.
  /// </summary>
  /// <param name = "properties">StatisticProperties instance containing the model property value.</param>
  public void CopyFrom(StatisticProperties properties)
  {
    var modelType = properties.GetType();
    foreach (var modelProperty in modelType.GetModelProperties())
    {
      var value = modelProperty.GetValue(properties);
      modelProperty.SetValue(this, value);
    }

    var updatableElement = GetUpdatableObject();
    if (updatableElement != null)
      UpdateData(updatableElement);
  }

  /// <summary>
  ///   The total number of pages of a document if applicable.
  /// </summary>
  [BuiltInProperty("Number of pages")]
  [OpenXmlProperty(nameof(DXEP.Properties.Pages))]
  public int? Pages
  {
    get => _Pages ??= GetProperty<int?>(OpenXmlProperties?.Pages);
    set => UpdateField(ref _Pages, value, nameof(Pages));
  }
  private int? _Pages;

  /// <summary>
  ///   The total number of words of a document if applicable.
  /// </summary>
  [BuiltInProperty("Number of words")]
  [OpenXmlProperty(nameof(DXEP.Properties.Words))]
  public int? Words
  {
    get => _Words ??= GetProperty<int?>(OpenXmlProperties?.Words);
    set => UpdateField(ref _Words, value, nameof(Words));
  }
  private int? _Words;

  /// <summary>
  ///   The total number of characters in a document.
  /// </summary>
  [BuiltInProperty("Number of characters")]
  [OpenXmlProperty(nameof(DXEP.Properties.Characters))]
  public int? Characters
  {
    get => _Characters ??= GetProperty<int?>(OpenXmlProperties?.Characters);
    set => UpdateField(ref _Characters, value, nameof(Characters));
  }
  private int? _Characters;

  /// <summary>
  ///   The total number of lines in a document when last saved by a conforming producer if applicable.
  /// </summary>
  [BuiltInProperty("Number of lines")]
  [OpenXmlProperty(nameof(DXEP.Properties.Lines))]
  public int? Lines
  {
    get => _Lines ??= GetProperty<int?>(OpenXmlProperties?.Lines);
    set => UpdateField(ref _Lines, value, nameof(Lines));
  }
  private int? _Lines;

  /// <summary>
  ///   The total number of paragraphs found in a document if applicable.
  /// </summary>
  [BuiltInProperty("Number of paragraphs")]
  [OpenXmlProperty(nameof(DXEP.Properties.Paragraphs))]
  public int? Paragraphs
  {
    get => _Paragraphs ??= GetProperty<int?>(OpenXmlProperties?.Paragraphs);
    set => UpdateField(ref _Paragraphs, value, nameof(Paragraphs));
  }
  private int? _Paragraphs;

  /// <summary>
  ///   The last count of the number of characters (including spaces) in this document.
  /// </summary>
  [BuiltInProperty("Number of characters (with spaces)")]
  [OpenXmlProperty(nameof(DXEP.Properties.CharactersWithSpaces))]
  public int? CharactersWithSpaces
  {
    get => _CharactersWithSpaces ??= GetProperty<int?>(OpenXmlProperties?.CharactersWithSpaces);
    set => UpdateField(ref _CharactersWithSpaces, value, nameof(CharactersWithSpaces));
  }
  private int? _CharactersWithSpaces;

  /// <summary>
  ///  The total number of slides in a presentation document.
  /// </summary>
  [BuiltInProperty("Number of slides")]
  [OpenXmlProperty(nameof(DXEP.Properties.Slides))]
  public int? Slides
  {
    get => _Slides ??= GetProperty<int?>(OpenXmlProperties?.Slides);
    set => UpdateField(ref _Slides, value, nameof(Slides));
  }
  private int? _Slides;

  /// <summary>
  ///  The number of slides in a presentation containing notes.
  /// </summary>
  [BuiltInProperty("Number of notes")]
  [OpenXmlProperty(nameof(DXEP.Properties.Notes))]
  public int? Notes
  {
    get => _Notes ??= GetProperty<int?>(OpenXmlProperties?.Notes);
    set => UpdateField(ref _Notes, value, nameof(Notes));
  }
  private int? _Notes;

  /// <summary>
  ///   The number of hidden slides in a presentation document.
  /// </summary>
  [BuiltInProperty("Number of hidden Slides")]
  [OpenXmlProperty(nameof(DXEP.Properties.HiddenSlides))]
  public int? HiddenSlides
  {
    get => _HiddenSlides ??= GetProperty<int?>(OpenXmlProperties?.HiddenSlides);
    set => UpdateField(ref _HiddenSlides, value, nameof(HiddenSlides));
  }
  private int? _HiddenSlides;

  /// <summary>
  ///   The total number of sound or video clips that are present in the document.
  /// </summary>
  [BuiltInProperty("Number of multimedia clips")]
  [OpenXmlProperty(nameof(DXEP.Properties.MultimediaClips))]
  public int? MultimediaClips
  {
    get => _MultimediaClips ??= GetProperty<int?>(OpenXmlProperties?.MultimediaClips);
    set => UpdateField(ref _MultimediaClips, value, nameof(MultimediaClips));
  }
  private int? _MultimediaClips;

  /// <summary>
  ///   Total time that a document has been edited. The default time unit is minutes.
  /// </summary>
  [BuiltInProperty("Total editing time")]
  [Unit("min")]
  [OpenXmlProperty(nameof(DXEP.Properties.TotalTime))]
  public int? TotalTime
  {
    get => _TotalTime ??= GetProperty<int?>(OpenXmlProperties?.TotalTime);
    set => UpdateField(ref _TotalTime, value, nameof(TotalTime));
  }
  private int? _TotalTime;
}