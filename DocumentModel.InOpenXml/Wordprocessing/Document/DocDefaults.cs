namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents the default paragraph and run properties for a WordprocessingML document.
///   This class provides properties for specifying the default character-level and paragraph-level formatting applied to all runs and paragraphs in the document unless overridden by more specific formatting.
/// </summary>
[OpenXmlType(typeof(DXW.DocDefaults))]
public sealed partial class DocDefaults: ModelElement<DXW.DocDefaults>
{
  /// <summary>
  /// Default constructor.
  /// </summary>
  public DocDefaults()
  {
  }

  /// <summary>
  /// Initializing constructor.
  /// </summary>
  /// <param name = "styles">The styles to attach to.</param>
  public DocDefaults(Styles styles)
  {
    if (styles.WordprocessingDocument != null)
      AttachAndLoad(styles.WordprocessingDocument);
  }

  /// <summary>
  ///   Default run properties, specifying the default character-level formatting for text runs.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.DocDefaults.RunPropertiesDefault))]
  public DefaultRunProperties? DefaultRunProperties
  {
    get => _defaultRunProperties;
    set => UpdateField(ref _defaultRunProperties, value, nameof(DefaultRunProperties));
  }

  private DefaultRunProperties? _defaultRunProperties;

  /// <summary>
  ///   Default paragraph properties, specifying the default paragraph-level formatting for paragraphs.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.DocDefaults.ParagraphPropertiesDefault))]
  public DefaultParagraphProperties? DefaultParagraphProperties
  {
    get => _defaultParagraphProperties;
    set => UpdateField(ref _defaultParagraphProperties, value, nameof(DefaultParagraphProperties));
  }

  private DefaultParagraphProperties? _defaultParagraphProperties;
}