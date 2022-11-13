namespace DocxDocument.Model;

public class Document
{
  /// <summary>
  /// FileName with extension
  /// </summary>
  public string? Name { get; set; }

  /// <summary>
  /// Folder location of the document
  /// </summary>
  public string? Path { get; set; }


  /// <summary>
  /// FileName with extension
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  public string? FullName
  {
    get => System.IO.Path.Combine(Path ?? "", Name ?? "");
    set
    {
      if (value != null)
      {
        Path = System.IO.Path.GetDirectoryName(value);
        Name = System.IO.Path.GetFileName(value);
      }
    }
  }

  #region DocumentProperties
  [XmlElement]
  public DocumentProperties? Properties { get; set;}

  [XmlElement]
  public CustomDocumentProperties? CustomDocumentProperties { get; set; }

  [XmlElement]
  public Revisions? Revisions { get; set; }

  //public bool ShouldSerializeDocumentProperties() => Properties != null && !Properties.IsEmpty();
  #endregion

  #region Settings

  public DocumentSettings? Settings
  {
    get => _Settings;
    set
    {
      _Settings = value;
      //if (_Settings != null)
      //  _Settings.Document = this;
    }
  }
  private DocumentSettings? _Settings;

  public bool ShouldSerializeSettings() => Settings != null && !Settings.IsEmpty();

  #endregion

  #region ListDefinitions

  public ListDefinitions? ListDefinitions
  {
    get => _ListDefinitions;
    set
    {
      _ListDefinitions = value;
      if (_ListDefinitions != null)
        _ListDefinitions.Document = this;
    }
  }
  private ListDefinitions? _ListDefinitions;

  public bool ShouldSerializeListDefinitions() => ListDefinitions != null && !ListDefinitions.IsEmpty();
  #endregion

  #region Styles

  public Styles? Styles
  {
    get => _Styles;
    set
    {
      _Styles = value;
      if (_Styles != null)
        _Styles.Document = this;
    }
  }
  private Styles? _Styles;
  #endregion

  #region Theme

  public Theme? DocumentTheme
  {
    get => _DocumentTheme;
    set
    {
      if (_DocumentTheme != value)
      {
        _DocumentTheme = value;
        if (_DocumentTheme != null)
          _DocumentTheme.Document = this;
      }
    }
  }
  private Theme? _DocumentTheme;

  #endregion

  #region Contents
  public Body? Body { get; private set; } = null!;
  #endregion


  //public WD.OMaths OMaths { get; }
  //public WD.ContentControls ContentControls { get; }
  //public Microsoft.Office.Core.DocumentInspectors DocumentInspectors { get; }
  //public WD.Bibliography Bibliography { get; }
  //public Microsoft.Office.Core.CustomXMLParts CustomXMLParts { get; }
  //public WD.Research Research { get; }
  //public WD.CoAuthoring CoAuthoring { get; }
  //public WD.Broadcast Broadcast { get; }

  //public WD.Bookmarks Bookmarks { get; }
  //public WD.Tables Tables { get; }
  //public WD.Footnotes Footnotes { get; }
  //public WD.Endnotes Endnotes { get; }
  //public WD.Comments Comments { get; }
  //public WD.WdDocumentType Type { get; }
  //public WD.Sections Sections { get; }
  //public WD.Paragraphs Paragraphs { get; }
  //public WD.Words Words { get; }
  //public WD.Sentences Sentences { get; }
  //public WD.Characters Characters { get; }
  //public WD.Fields Fields { get; }
  //public WD.FormFields FormFields { get; }
  //public WD.Frames Frames { get; }
  //public WD.TablesOfFigures TablesOfFigures { get; }
  //public WD.Variables Variables { get; }
  //public WD.MailMerge MailMerge { get; }
  //public WD.Envelope Envelope { get; }
  //public WD.Revisions Revisions { get; }
  //public WD.TablesOfContents TablesOfContents { get; }
  //public WD.TablesOfAuthorities TablesOfAuthorities { get; }
  //public WD.PageSetup PageSetup { get; set; }
  //public WD.Windows Windows { get; }
  //public WD.RoutingSlip RoutingSlip { get; }
  //public WD.TablesOfAuthoritiesCategories TablesOfAuthoritiesCategories { get; }
  //public WD.Indexes Indexes { get; }
  //public WD.Range Content { get; }
  //public WD.Window ActiveWindow { get; }
  //public WD.WdDocumentKind Kind { get; set; }
  //public WD.Subdocuments Subdocuments { get; }
  //public WD.StoryRanges StoryRanges { get; }
  //public WD.WdProtectionType ProtectionType { get; }
  //public WD.Hyperlinks Hyperlinks { get; }
  //public WD.Shapes Shapes { get; }
  //public WD.ListTemplates ListTemplates { get; }
  //public WD.Lists Lists { get; }
  //public WD.InlineShapes InlineShapes { get; }
  //public WD.Shape Background { get; set; }
  //public WD.Versions Versions { get; }
  //public WD.WdSummaryMode SummaryViewMode { get; set; }
  //public WD.ListParagraphs ListParagraphs { get; }
  //public WD.Mailer Mailer { get; }
  //public WD.ReadabilityStatistics ReadabilityStatistics { get; }
  //public WD.ProofreadingErrors GrammaticalErrors { get; }
  //public WD.ProofreadingErrors SpellingErrors { get; }
  //public WD.WdJustificationMode JustificationMode { get; set; }
  //public WD.WdFarEastLineBreakLevel FarEastLineBreakLevel { get; set; }
  //public WD.Email Email { get; }
  //public WD.WdFarEastLineBreakLanguageID FarEastLineBreakLanguage { get; set; }
  //public WD.Frameset Frameset { get; }
  //public WD.WebOptions WebOptions { get; }
  //public WD.HTMLDivisions HTMLDivisions { get; }
  //public WD.WdDisableFeaturesIntroducedAfter DisableFeaturesIntroducedAfter { get; set; }
  //public WD.SmartTags SmartTags { get; }
  //public WD.WdLineEndingType TextLineEnding { get; set; }
  //public WD.StyleSheets StyleSheets { get; }
  //public WD.WdShowFilter FormattingShowFilter { get; set; }
  //public Microsoft.Office.Core.Permission Permission { get; }
  //public WD.XMLNodes XMLNodes { get; }
  //public WD.XMLSchemaReferences XMLSchemaReferences { get; }
  //public WD.XMLChildNodeSuggestions ChildNodeSuggestions { get; }
  //public WD.XMLNodes XMLSchemaViolations { get; }

}