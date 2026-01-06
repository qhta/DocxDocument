namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents the bibliography and citation management system in a document.
/// </summary>
/// <remarks>
///   The Bibliography interface provides access to the sources, citations, and formatting
///   used for managing references in academic and professional documents. It corresponds
///   to the Microsoft.Office.Interop.Word.Bibliography interface.
/// </remarks>
public interface Bibliography
{
  #region Sources Management

  /// <summary>
  ///   Gets the collection of all sources (references) available in the document.
  /// </summary>
  /// <remarks>
  ///   Sources represent the bibliographic references that can be cited in the document.
  ///   Each source contains metadata such as author, title, year, publisher, etc.
  /// </remarks>
  public Sources? Sources { get; }

  /// <summary>
  ///   Gets or sets the master list of all sources across all documents.
  /// </summary>
  /// <remarks>
  ///   The master list is a shared repository of sources that can be used across
  ///   multiple documents. It's typically stored separately from individual documents.
  /// </remarks>
  public Sources? MasterList { get; set; }

  /// <summary>
  ///   Gets or sets the current list of sources in the active document.
  /// </summary>
  /// <remarks>
  ///   The current list contains only the sources that are currently being used
  ///   or referenced in the active document.
  /// </remarks>
  public Sources? CurrentList { get; set; }

  #endregion

  #region Bibliography Style and Formatting

  /// <summary>
  ///   Gets or sets the bibliographic style used for formatting citations and bibliography.
  /// </summary>
  /// <remarks>
  ///   Common styles include APA, MLA, Chicago, Turabian, IEEE, etc.
  ///   The style determines how citations appear in-text and how the bibliography is formatted.
  /// </remarks>
  public string? BibliographyStyle { get; set; }

  /// <summary>
  ///   Gets or sets the sort order for the bibliography entries.
  /// </summary>
  /// <remarks>
  ///   Determines how bibliography entries are ordered (alphabetically by author,
  ///   by appearance in document, by year, etc.).
  /// </remarks>
  public BibliographySortOrderKind? SortOrder { get; set; }

  /// <summary>
  ///   Gets or sets whether to show all bibliography sources or only cited sources.
  /// </summary>
  /// <remarks>
  ///   When true, displays all sources in the current list.
  ///   When false, displays only sources that are actually cited in the document.
  /// </remarks>
  public bool ShowAllSources { get; set; }

  #endregion

  #region Bibliography Generation

  /// <summary>
  ///   Generates or updates the bibliography in the document.
  /// </summary>
  /// <remarks>
  ///   Creates a formatted bibliography section containing all cited sources
  ///   according to the selected bibliographic style.
  /// </remarks>
  public void GenerateBibliography();

  /// <summary>
  ///   Converts the bibliography to static text.
  /// </summary>
  /// <remarks>
  ///   Converts the dynamic bibliography field to plain text, breaking the link
  ///   to the sources. This is useful for final documents where changes are no longer needed.
  /// </remarks>
  public void ConvertToStaticText();

  /// <summary>
  ///   Updates all citations in the document.
  /// </summary>
  /// <remarks>
  ///   Refreshes all citation fields to reflect any changes made to the source information
  ///   or bibliography style.
  /// </remarks>
  public void UpdateCitations();

  #endregion

  #region Source Operations

  /// <summary>
  ///   Adds a new source to the bibliography.
  /// </summary>
  /// <param name="source">The source object to add.</param>
  /// <returns>The added source with any generated fields populated.</returns>
  public Source? AddSource(Source source);

  /// <summary>
  ///   Removes a source from the bibliography.
  /// </summary>
  /// <param name="tag">The unique identifier (tag) of the source to remove.</param>
  /// <returns>True if the source was successfully removed.</returns>
  public bool RemoveSource(string tag);

  /// <summary>
  ///   Finds a source by its unique tag identifier.
  /// </summary>
  /// <param name="tag">The unique identifier of the source.</param>
  /// <returns>The source object if found, otherwise null.</returns>
  public Source? FindSource(string tag);

  /// <summary>
  ///   Checks if a source with the specified tag exists.
  /// </summary>
  /// <param name="tag">The unique identifier to check.</param>
  /// <returns>True if a source with the tag exists.</returns>
  public bool SourceExists(string tag);

  /// <summary>
  ///   Creates a copy of an existing source.
  /// </summary>
  /// <param name="sourceTag">The tag of the source to copy.</param>
  /// <returns>A new source object with a new unique tag.</returns>
  public Source? CopySource(string sourceTag);

  #endregion

  #region Citation Insertion

  /// <summary>
  ///   Inserts a citation at the specified range.
  /// </summary>
  /// <param name="range">The range where the citation should be inserted.</param>
  /// <param name="sourceTag">The tag of the source to cite.</param>
  /// <param name="pageNumbers">Optional page numbers for the citation.</param>
  /// <param name="suppressAuthor">Whether to suppress the author in the citation.</param>
  /// <param name="suppressYear">Whether to suppress the year in the citation.</param>
  /// <param name="suppressTitle">Whether to suppress the title in the citation.</param>
  /// <returns>The inserted citation field.</returns>
  public Field? InsertCitation(Range range, string sourceTag, string? pageNumbers = null,
                                bool suppressAuthor = false, bool suppressYear = false,
                                bool suppressTitle = false);

  /// <summary>
  ///   Inserts a bibliography at the specified range.
  /// </summary>
  /// <param name="range">The range where the bibliography should be inserted.</param>
  /// <param name="style">Optional style to use (overrides document default).</param>
  /// <returns>The inserted bibliography content control or field.</returns>
  public object? InsertBibliography(Range range, string? style = null);

  #endregion

  #region Import and Export

  /// <summary>
  ///   Imports sources from an external file.
  /// </summary>
  /// <param name="fileName">Path to the file containing sources.</param>
  /// <param name="format">Format of the source file (BibTeX, EndNote, RIS, etc.).</param>
  /// <returns>Number of sources imported.</returns>
  public int ImportSources(string fileName, BibliographyFormatKind format);

  /// <summary>
  ///   Exports sources to an external file.
  /// </summary>
  /// <param name="fileName">Path where the sources should be exported.</param>
  /// <param name="format">Format for the exported file.</param>
  /// <param name="sourceTags">Optional list of specific source tags to export. If null, exports all sources.</param>
  /// <returns>Number of sources exported.</returns>
  public int ExportSources(string fileName, BibliographyFormatKind format, string[]? sourceTags = null);

  /// <summary>
  ///   Imports sources from XML string.
  /// </summary>
  /// <param name="xml">XML string containing source definitions.</param>
  /// <returns>Number of sources imported.</returns>
  public int ImportSourcesFromXml(string xml);

  /// <summary>
  ///   Exports sources to XML string.
  /// </summary>
  /// <param name="sourceTags">Optional list of specific source tags to export.</param>
  /// <returns>XML string containing source definitions.</returns>
  public string ExportSourcesToXml(string[]? sourceTags = null);

  #endregion

  #region Style Management

  /// <summary>
  ///   Gets the list of available bibliography styles.
  /// </summary>
  /// <returns>Collection of style names.</returns>
  public string[] GetAvailableStyles();

  /// <summary>
  ///   Gets information about a specific bibliography style.
  /// </summary>
  /// <param name="styleName">Name of the style.</param>
  /// <returns>Style information object.</returns>
  public BibliographyStyleInfo? GetStyleInfo(string styleName);

  /// <summary>
  ///   Validates whether a style name is valid and available.
  /// </summary>
  /// <param name="styleName">Name of the style to validate.</param>
  /// <returns>True if the style is valid and available.</returns>
  public bool IsStyleAvailable(string styleName);

  #endregion

  #region Statistics and Information

  /// <summary>
  ///   Gets the count of sources in the current list.
  /// </summary>
  public int SourceCount { get; }

  /// <summary>
  ///   Gets the count of sources actually cited in the document.
  /// </summary>
  public int CitedSourceCount { get; }

  /// <summary>
  ///   Gets the count of uncited sources in the current list.
  /// </summary>
  public int UncitedSourceCount { get; }

  /// <summary>
  ///   Gets the count of citations in the document.
  /// </summary>
  public int CitationCount { get; }

  /// <summary>
  ///   Gets whether the bibliography has been inserted in the document.
  /// </summary>
  public bool IsBibliographyInserted { get; }

  #endregion

  #region Validation and Cleanup

  /// <summary>
  ///   Validates all sources for completeness and correctness.
  /// </summary>
  /// <returns>Collection of validation issues found.</returns>
  public ValidationIssue[] ValidateSources();

  /// <summary>
  ///   Removes all uncited sources from the current list.
  /// </summary>
  /// <returns>Number of sources removed.</returns>
  public int RemoveUncitedSources();

  /// <summary>
  ///   Finds and removes duplicate sources.
  /// </summary>
  /// <param name="autoMerge">Whether to automatically merge duplicate citations.</param>
  /// <returns>Number of duplicate sources removed.</returns>
  public int RemoveDuplicateSources(bool autoMerge = true);

  /// <summary>
  ///   Checks for broken citation links.
  /// </summary>
  /// <returns>Collection of citation fields with missing or invalid source references.</returns>
  public Field[] FindBrokenCitations();

  #endregion

  #region Events

  /// <summary>
  ///   Occurs when a source is added to the bibliography.
  /// </summary>
  public event EventHandler<SourceEventArgs>? SourceAdded;

  /// <summary>
  ///   Occurs when a source is removed from the bibliography.
  /// </summary>
  public event EventHandler<SourceEventArgs>? SourceRemoved;

  /// <summary>
  ///   Occurs when a source is modified.
  /// </summary>
  public event EventHandler<SourceEventArgs>? SourceModified;

  /// <summary>
  ///   Occurs when the bibliography style is changed.
  /// </summary>
  public event EventHandler<StyleChangedEventArgs>? StyleChanged;

  /// <summary>
  ///   Occurs when the bibliography is generated or updated.
  /// </summary>
  public event EventHandler? BibliographyGenerated;

  #endregion
}