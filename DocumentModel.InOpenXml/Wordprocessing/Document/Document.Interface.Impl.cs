namespace DocumentModel.Wordprocessing;

public partial class Document: IDocument
{
  string? IDocument.ActiveTheme => throw new NotImplementedException();
  string? IDocument.ActiveThemeDisplayName => throw new NotImplementedException();
  IWindow? IDocument.ActiveWindow => throw new NotImplementedException();
  ITemplate? IDocument.AttachedTemplate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
  bool IDocument.AutoFormatOverride { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
  bool IDocument.AutoHyphenation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
  DMD.IShape? IDocument.Background { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
  IBibliography? IDocument.Bibliography => throw new NotImplementedException();
  IBookmarks? IDocument.Bookmarks => throw new NotImplementedException();

  /// <summary>
  /// Gets the built-in properties of the document.
  /// This property allows access to built-in document properties through a collection interface.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  public BuiltInProperties BuiltInProperties
  {
    get => _builtInProperties ??= new BuiltInProperties(this);
    set => UpdateField(ref _builtInProperties, value, nameof(BuiltInProperties));
  }
  private BuiltInProperties? _builtInProperties;
  DMPr.IDocumentProperties IDocument.BuiltInDocumentProperties => new BuiltInPropertiesWrapper(BuiltInProperties);
  
  ICharacters? IDocument.Characters => throw new NotImplementedException();
  bool IDocument.ChartDataPointTrack { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
  object? IDocument.ClickAndTypeParagraphStyle { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
  ICoAuthoring? IDocument.CoAuthoring => throw new NotImplementedException();
  IComments? IDocument.Comments => throw new NotImplementedException();
  int? IDocument.CompatibilityMode => throw new NotImplementedException();
  int? IDocument.ConsecutiveHyphensLimit { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
  object? IDocument.Container => throw new NotImplementedException();
  IRange? IDocument.Content => throw new NotImplementedException();
  IContentControls? IDocument.ContentControls => throw new NotImplementedException();
  DMPr.IMetaProperties? IDocument.ContentTypeProperties => throw new NotImplementedException();
  int? IDocument.CurrentRsid => throw new NotImplementedException();
  DMPr.ICustomProperties? IDocument.CustomDocumentProperties => throw new NotImplementedException();
  DMCX.ICustomXMLParts? IDocument.CustomXMLParts => throw new NotImplementedException();
  ITableStyle? IDocument.DefaultTableStyle => throw new NotImplementedException();
  float? IDocument.DefaultTabStop { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
  string? IDocument.DefaultTargetFrame { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
  int? IDocument.DocID => throw new NotImplementedException();
  DMT.ITheme? IDocument.DocumentTheme => throw new NotImplementedException();
  IEndnotes? IDocument.Endnotes => throw new NotImplementedException();
  bool IDocument.EnforceStyle { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
  IEnvelope? IDocument.Envelope => throw new NotImplementedException();
  FarEastLineBreakLanguageID? IDocument.FarEastLineBreakLanguage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
  FarEastLineBreakLevel? IDocument.FarEastLineBreakLevel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
  IFields? IDocument.Fields => throw new NotImplementedException();
  bool IDocument.Final { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
  IFootnotes? IDocument.Footnotes => throw new NotImplementedException();
  bool IDocument.FormattingShowClear { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
  ShowFilter? IDocument.FormattingShowFilter { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
  bool IDocument.FormattingShowFont { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
  bool IDocument.FormattingShowNextLevel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
  bool IDocument.FormattingShowNumbering { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
  bool IDocument.FormattingShowParagraph { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
  bool IDocument.FormattingShowUserStyleName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
  IFormFields? IDocument.FormFields => throw new NotImplementedException();
  bool IDocument.FormsDesign => throw new NotImplementedException();
  IFrames? IDocument.Frames => throw new NotImplementedException();
  IFrameset? IDocument.Frameset => throw new NotImplementedException();
  string? IDocument.FullName => throw new NotImplementedException();
  bool IDocument.GrammarChecked { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
  IProofreadingErrors? IDocument.GrammaticalErrors => throw new NotImplementedException();
  float? IDocument.GridDistanceHorizontal { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
  float? IDocument.GridDistanceVertical { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
  bool IDocument.GridOriginFromMargin { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
  float? IDocument.GridOriginHorizontal { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
  float? IDocument.GridOriginVertical { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
  int? IDocument.GridSpaceBetweenHorizontalLines { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
  int? IDocument.GridSpaceBetweenVerticalLines { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
  bool IDocument.HasMailer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
  bool IDocument.HasPassword => throw new NotImplementedException();
  bool IDocument.HasRoutingSlip { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
  bool IDocument.HasVBProject => throw new NotImplementedException();
  IHTMLDivisions? IDocument.HTMLDivisions => throw new NotImplementedException();
  DMH.IHTMLProject? IDocument.HTMLProject => throw new NotImplementedException();
  IHyperlinks? IDocument.Hyperlinks => throw new NotImplementedException();
  bool IDocument.HyphenateCaps { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
  int? IDocument.HyphenationZone { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
  IIndexes? IDocument.Indexes => throw new NotImplementedException();
  DMD.IInlineShapes? IDocument.InlineShapes => throw new NotImplementedException();
  bool IDocument.IsInAutosave => throw new NotImplementedException();
  bool IDocument.IsMasterDocument => throw new NotImplementedException();
  bool IDocument.IsSubdocument => throw new NotImplementedException();
  JustificationMode? IDocument.JustificationMode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
  bool IDocument.KerningByAlgorithm { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
  DocumentKind? IDocument.Kind { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
  bool IDocument.LanguageDetected { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
  IListParagraphs? IDocument.ListParagraphs => throw new NotImplementedException();
  ILists? IDocument.Lists => throw new NotImplementedException();
  IListTemplates? IDocument.ListTemplates => throw new NotImplementedException();
  bool IDocument.LockQuickStyleSet { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
  bool IDocument.LockTheme { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
  IMailer? IDocument.Mailer => throw new NotImplementedException();
  IMailMerge? IDocument.MailMerge => throw new NotImplementedException();
  string? IDocument.Name => throw new NotImplementedException();
  string? IDocument.NoLineBreakAfter { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
  string? IDocument.NoLineBreakBefore { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
  string? IDocument.OriginalDocumentTitle => throw new NotImplementedException();
  IPageSetup? IDocument.PageSetup { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
  IParagraphs? IDocument.Paragraphs => throw new NotImplementedException();
  string? IDocument.Path => throw new NotImplementedException();
  bool IDocument.ReadOnly => throw new NotImplementedException();
  IRevisions? IDocument.Revisions => throw new NotImplementedException();
  bool IDocument.Saved { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
  int? IDocument.SaveFormat => throw new NotImplementedException();
  bool IDocument.SaveFormsData { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
  bool IDocument.SaveSubsetFonts { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
  DMH.IScripts? IDocument.Scripts => throw new NotImplementedException();
  ISections? IDocument.Sections => throw new NotImplementedException();
  ISentences? IDocument.Sentences => throw new NotImplementedException();
  DMD.IShapes? IDocument.Shapes => throw new NotImplementedException();
  IStoryRanges? IDocument.StoryRanges => throw new NotImplementedException();

  IStyles? IDocument.Styles => throw new NotImplementedException();

  IStyleSheets? IDocument.StyleSheets => throw new NotImplementedException();
  ISubdocuments? IDocument.Subdocuments => throw new NotImplementedException();
  ITables? IDocument.Tables => throw new NotImplementedException();
  ITablesOfAuthorities? IDocument.TablesOfAuthorities => throw new NotImplementedException();
  ITablesOfAuthoritiesCategories? IDocument.TablesOfAuthoritiesCategories => throw new NotImplementedException();
  ITablesOfContents? IDocument.TablesOfContents => throw new NotImplementedException();
  ITablesOfFigures? IDocument.TablesOfFigures => throw new NotImplementedException();
  IVariables? IDocument.Variables => throw new NotImplementedException();
  IVersions? IDocument.Versions => throw new NotImplementedException();
  IWebOptions? IDocument.WebOptions => throw new NotImplementedException();
  IWindows? IDocument.Windows => throw new NotImplementedException();
  IWords? IDocument.Words => throw new NotImplementedException();
}