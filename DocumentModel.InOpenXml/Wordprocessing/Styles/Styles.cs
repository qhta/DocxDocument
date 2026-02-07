namespace DocumentModel.Wordprocessing;
#pragma warning disable CS8601 // Possible null reference assignment.

/// <summary>
/// Represents the collection of styles in a Wordprocessing document.
/// This class provides access to document default paragraph and run properties, latent style information, and defined styles, enabling advanced style management and formatting for document content.
/// </summary>
[OpenXmlType(typeof(DXW.Styles))]
public sealed partial class Styles : ModelElement<DXW.Styles>
{
  /// <summary>
  /// Default constructor.
  /// </summary>
  public Styles()
  {
    _LatentStyles = new LatentStyles(this);
    _DefinedStyles = new DefinedStyles(this);
  }

  /// <summary>
  /// Initializing constructor.
  /// </summary>
  /// <param name = "document">The document to attach to.</param>
  public Styles(Document document) : this()
  {
    if (document.WordprocessingDocument != null)
      AttachAndLoad(document.WordprocessingDocument);
  }

  /// <summary>
  /// Attach this instance to the specified wordprocessingDocument. Data is loaded from the wordprocessingDocument's FontTable.
  /// </summary>
  /// <param name = "wordprocessingDocument">Document to attach to.</param>
  public override void AttachAndLoad(DXPP.WordprocessingDocument wordprocessingDocument)
  {
    base.AttachAndLoad(wordprocessingDocument);
    var styles = wordprocessingDocument.GetStyles();
    SetUpdatableElement(styles);
    LoadData(styles);
  }

  /// <summary>
  /// Attach this instance to the specified document. Data is stored to the document's FontTable.
  /// </summary>
  /// <param name = "wordprocessingDocument">Document to attach to.</param>
  public override void AttachAndUpdate(DXPP.WordprocessingDocument wordprocessingDocument)
  {
    base.AttachAndUpdate(wordprocessingDocument);
    var styles = wordprocessingDocument.GetStyles();
    SetUpdatableElement(styles);
    UpdateData(styles);
  }

  /// <summary>
  /// Document default paragraph and run properties, specifying default formatting for paragraphs and text runs.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Styles.DocDefaults))]
  public DocDefaults? DocDefaults { get => _DocDefaults; set => UpdateField(ref _DocDefaults, value, nameof(DocDefaults)); }

  private DocDefaults? _DocDefaults;
  /// <summary>
  /// Latent style information, providing metadata and settings for latent styles in the document.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.Styles.LatentStyles))]
  public LatentStyles LatentStyles { get => _LatentStyles; set => UpdateField(ref _LatentStyles, value, nameof(LatentStyles)); }

  private LatentStyles _LatentStyles;
  /// <summary>
  /// Collection of defined styles in the document, including paragraph, character, table, and numbering styles.
  /// </summary>
  [OpenXmlElementCollection(typeof(DXW.Style))]
  public DefinedStyles DefinedStyles { get => _DefinedStyles; set => UpdateField(ref _DefinedStyles, value, nameof(DefinedStyles)); }

  private DefinedStyles _DefinedStyles;
}