namespace DocumentModel.Wordprocessing;
/// <summary>
///   Represents the bibliography and citation management system in a document.
/// </summary>
/// <remarks>
///   The Bibliography interface provides access to the sources, citations, and formatting
///   used for managing references in academic and professional documents. It corresponds
///   to the Microsoft.Office.Interop.Word.Bibliography class.
/// </remarks>
[OpenXmlNotMapped]
public partial class Bibliography : ModelElement
{
#region Sources Management
    /// <summary>
    ///   Gets the collection of all sources (references) available in the document.
    /// </summary>
    /// <remarks>
    ///   Sources represent the bibliographic references that can be cited in the document.
    ///   Each source contains metadata such as author, title, year, publisher, etc.
    /// </remarks>
    public Sources? Sources { get => _Sources; set => UpdateField(ref _Sources, value, nameof(Sources)); }

    private Sources? _Sources;
    /// <summary>
    ///   Gets or sets the master list of all sources across all documents.
    /// </summary>
    /// <remarks>
    ///   The master list is a shared repository of sources that can be used across
    ///   multiple documents. It's typically stored separately from individual documents.
    /// </remarks>
    public Sources? MasterList { get => _MasterList; set => UpdateField(ref _MasterList, value, nameof(MasterList)); }

    private Sources? _MasterList;
    /// <summary>
    ///   Gets or sets the current list of sources in the active document.
    /// </summary>
    /// <remarks>
    ///   The current list contains only the sources that are currently being used
    ///   or referenced in the active document.
    /// </remarks>
    public Sources? CurrentList { get => _CurrentList; set => UpdateField(ref _CurrentList, value, nameof(CurrentList)); }

    private Sources? _CurrentList;
#endregion
#region Bibliography Style and Formatting
    /// <summary>
    ///   Gets or sets the bibliographic style used for formatting citations and bibliography.
    /// </summary>
    /// <remarks>
    ///   Common styles include APA, MLA, Chicago, Turabian, IEEE, etc.
    ///   The style determines how citations appear in-text and how the bibliography is formatted.
    /// </remarks>
    public string? BibliographyStyle { get => _BibliographyStyle; set => UpdateField(ref _BibliographyStyle, value, nameof(BibliographyStyle)); }

    private string? _BibliographyStyle;
    /// <summary>
    ///   Gets or sets the sort order for the bibliography entries.
    /// </summary>
    /// <remarks>
    ///   Determines how bibliography entries are ordered (alphabetically by author,
    ///   by appearance in document, by year, etc.).
    /// </remarks>
    public BibliographySortOrder? SortOrder { get => _SortOrder; set => UpdateField(ref _SortOrder, value, nameof(SortOrder)); }

    private BibliographySortOrder? _SortOrder;
    /// <summary>
    ///   Gets or sets whether to show all bibliography sources or only cited sources.
    /// </summary>
    /// <remarks>
    ///   When true, displays all sources in the current list.
    ///   When false, displays only sources that are actually cited in the document.
    /// </remarks>
    public bool ShowAllSources { get => _ShowAllSources; set => UpdateField(ref _ShowAllSources, value, nameof(ShowAllSources)); }

    private bool _ShowAllSources;
#endregion
}