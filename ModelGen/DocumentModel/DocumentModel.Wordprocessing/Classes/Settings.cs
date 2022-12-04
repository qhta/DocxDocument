namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document Settings.
/// </summary>
public class Settings
{
  /// <summary>
  /// Write Protection.
  /// </summary>
  public WriteProtection? WriteProtection
  {
    get;
    set;
  }
  
  /// <summary>
  /// Document View Setting.
  /// </summary>
  public ViewKind? View
  {
    get;
    set;
  }
  
  /// <summary>
  /// Magnification Setting.
  /// </summary>
  public Zoom? Zoom
  {
    get;
    set;
  }
  
  public ProofState? ProofState
  {
    get;
    set;
  }
  
  public StylePaneFormatFilter? StylePaneFormatFilter
  {
    get;
    set;
  }
  
  public DocumentKind? DocumentType
  {
    get;
    set;
  }
  
  public MailMerge? MailMerge
  {
    get;
    set;
  }
  
  public RevisionView? RevisionView
  {
    get;
    set;
  }
  
  public DocumentProtection? DocumentProtection
  {
    get;
    set;
  }
  
  public CharacterSpacingKind? CharacterSpacingControl
  {
    get;
    set;
  }
  
  public NoLineBreaksAfterKinsoku? NoLineBreaksAfterKinsoku
  {
    get;
    set;
  }
  
  public NoLineBreaksBeforeKinsoku? NoLineBreaksBeforeKinsoku
  {
    get;
    set;
  }
  
  public SaveThroughXslt? SaveThroughXslt
  {
    get;
    set;
  }
  
  public HeaderShapeDefaults? HeaderShapeDefaults
  {
    get;
    set;
  }
  
  public FootnoteDocumentWideProperties? FootnoteDocumentWideProperties
  {
    get;
    set;
  }
  
  public EndnoteDocumentWideProperties? EndnoteDocumentWideProperties
  {
    get;
    set;
  }
  
  public Compatibility? Compatibility
  {
    get;
    set;
  }
  
  public DocumentVariables? DocumentVariables
  {
    get;
    set;
  }
  
  public Rsids? Rsids
  {
    get;
    set;
  }
  
  public DocumentModel.Math.MathProperties? MathProperties
  {
    get;
    set;
  }
  
  public ColorSchemeMapping? ColorSchemeMapping
  {
    get;
    set;
  }
  
  public Captions? Captions
  {
    get;
    set;
  }
  
  public ReadModeInkLockDown? ReadModeInkLockDown
  {
    get;
    set;
  }
  
  public DocumentModel.CustomXml.SchemaLibrary? SchemaLibrary
  {
    get;
    set;
  }
  
  public ShapeDefaults? ShapeDefaults
  {
    get;
    set;
  }
  
  public OnOffKind? DiscardImageEditingData
  {
    get;
    set;
  }
  
  public OnOffKind? ConflictMode
  {
    get;
    set;
  }
  
}
