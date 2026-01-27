namespace DocumentModel;
/// <summary>
///   This set of properties is evaluated on document change.
/// </summary>
[OpenXmlType(typeof(DXEP.Properties))]
public sealed partial class StatisticProperties : ModelElement<DXEP.Properties>
{
 /// <summary>
 /// Default constructor.
 /// </summary>
 public StatisticProperties()
 {
 }

 /// <summary>
 /// Initializing constructor.
 /// </summary>
 /// <param name = "document">Wordprocessing document model</param>
 public StatisticProperties(Wordprocessing.Document document)
 {
  if (document.WordprocessingDocument != null)
   AttachAndLoad(document.WordprocessingDocument);
 }

 /// <summary>
 /// Attach this instance to the specified wordprocessingDocument. Data is loaded from the wordprocessingDocument's PackageProperties.
 /// </summary>
 /// <param name = "wordprocessingDocument">Document to attach to.</param>
 public override void AttachAndLoad(DXPP.WordprocessingDocument wordprocessingDocument)
 {
  base.AttachAndLoad(wordprocessingDocument);
  var extendedFileProperties = wordprocessingDocument.GetExtendedFileProperties();
  SetOpenXmlElement(extendedFileProperties);
  LoadData(extendedFileProperties);
 }

 /// <summary>
 /// Attach this instance to the specified wordprocessingDocument. Data is stored to the wordprocessingDocument's PackageProperties.
 /// </summary>
 /// <param name = "wordprocessingDocument">Document to attach to.</param>
 public override void AttachAndUpdate(DXPP.WordprocessingDocument wordprocessingDocument)
 {
  base.AttachAndUpdate(wordprocessingDocument);
  var extendedFileProperties = wordprocessingDocument.GetExtendedFileProperties();
  SetOpenXmlElement(extendedFileProperties);
  UpdateData(extendedFileProperties);
 }

 /// <summary>
 /// Known properties that can be set in StatisticProperties
 /// </summary>
 public static KnownProperties KnownProperties { get; } = new KnownProperties(typeof(StatisticProperties));

 /// <summary>
 ///   The total number of pages of a document if applicable.
 /// </summary>
 [OpenXmlProperty(nameof(DXEP.Properties.Pages))]
 [OpenXmlElement(typeof(DXEP.Properties))]
 public int? Pages { get => _Pages; set => UpdateField(ref _Pages, value, nameof(Pages)); }

 private int? _Pages;
 /// <summary>
 ///   The total number of words of a document if applicable.
 /// </summary>
 [OpenXmlProperty(nameof(DXEP.Properties.Words))]
 [OpenXmlElement(typeof(DXEP.Properties))]
 public int? Words { get => _Words; set => UpdateField(ref _Words, value, nameof(Words)); }

 private int? _Words;
 /// <summary>
 ///   The total number of characters in a document.
 /// </summary>
 [OpenXmlProperty(nameof(DXEP.Properties.Characters))]
 [OpenXmlElement(typeof(DXEP.Properties))]
 public int? Characters { get => _Characters; set => UpdateField(ref _Characters, value, nameof(Characters)); }

 private int? _Characters;
 /// <summary>
 ///   The total number of lines in a document when last saved by a conforming producer if applicable.
 /// </summary>
 [OpenXmlProperty(nameof(DXEP.Properties.Lines))]
 [OpenXmlElement(typeof(DXEP.Properties))]
 public int? Lines { get => _Lines; set => UpdateField(ref _Lines, value, nameof(Lines)); }

 private int? _Lines;
 /// <summary>
 ///   The total number of paragraphs found in a document if applicable.
 /// </summary>
 [OpenXmlProperty(nameof(DXEP.Properties.Paragraphs))]
 [OpenXmlElement(typeof(DXEP.Properties))]
 public int? Paragraphs { get => _Paragraphs; set => UpdateField(ref _Paragraphs, value, nameof(Paragraphs)); }

 private int? _Paragraphs;
 /// <summary>
 ///   The last count of the number of characters (including spaces) in this document.
 /// </summary>
 [OpenXmlProperty(nameof(DXEP.Properties.CharactersWithSpaces))]
 [OpenXmlElement(typeof(DXEP.Properties))]
 public int? CharactersWithSpaces { get => _CharactersWithSpaces; set => UpdateField(ref _CharactersWithSpaces, value, nameof(CharactersWithSpaces)); }

 private int? _CharactersWithSpaces;
 /// <summary>
 ///  The total number of slides in a presentation document.
 /// </summary>
 [OpenXmlProperty(nameof(DXEP.Properties.Slides))]
 [OpenXmlElement(typeof(DXEP.Properties))]
 public int? Slides { get => _Slides; set => UpdateField(ref _Slides, value, nameof(Slides)); }

 private int? _Slides;
 /// <summary>
 ///  The number of slides in a presentation containing notes.
 /// </summary>
 [OpenXmlProperty(nameof(DXEP.Properties.Notes))]
 [OpenXmlElement(typeof(DXEP.Properties))]
 public int? Notes { get => _Notes; set => UpdateField(ref _Notes, value, nameof(Notes)); }

 private int? _Notes;
 /// <summary>
 ///   The number of hidden slides in a presentation document.
 /// </summary>
 [OpenXmlProperty(nameof(DXEP.Properties.HiddenSlides))]
 [OpenXmlElement(typeof(DXEP.Properties))]
 public int? HiddenSlides { get => _HiddenSlides; set => UpdateField(ref _HiddenSlides, value, nameof(HiddenSlides)); }

 private int? _HiddenSlides;
 /// <summary>
 ///   The total number of sound or video clips that are present in the document.
 /// </summary>
 [OpenXmlProperty(nameof(DXEP.Properties.MultimediaClips))]
 [OpenXmlElement(typeof(DXEP.Properties))]
 public int? MultimediaClips { get => _MultimediaClips; set => UpdateField(ref _MultimediaClips, value, nameof(MultimediaClips)); }

 private int? _MultimediaClips;
 /// <summary>
 ///   Total time that a document has been edited. The default time unit is minutes.
 /// </summary>
 [Unit("min")]
 /// <summary>
 ///   Total time that a document has been edited. The default time unit is minutes.
 /// </summary>
 [OpenXmlProperty(nameof(DXEP.Properties.TotalTime))]
 [OpenXmlElement(typeof(DXEP.Properties))]
 public int? TotalTime { get => _TotalTime; set => UpdateField(ref _TotalTime, value, nameof(TotalTime)); }

 private int? _TotalTime;
}