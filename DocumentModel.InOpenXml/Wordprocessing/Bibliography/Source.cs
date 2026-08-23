namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents a bibliographic source (reference).
/// </summary>
[OpenXmlType(typeof(DXB.Source))]
[DataContract]
[XmlRoot("Source", Namespace = "DocumentModel.Wordprocessing")]
public partial class Source: ModelElement<DXB.Source>
{
  /// <summary>
  ///   Gets or sets the unique identifier (tag) for the source.
  /// </summary>
  [OpenXmlProperty(nameof(DXB.Source.Tag))]
  public string? Tag
  {
    get => _Tag ??= GetProperty<string?>(GetUpdatableElement()?.Tag);
    set => UpdateField(ref _Tag, value, nameof(Tag));
  }

  private string? _Tag;

  /// <summary>
  ///   Gets or sets the type of source (book, journal article, website, etc.).
  /// </summary>
  [OpenXmlProperty(nameof(DXB.Source.SourceType))]
  public SourceType? SourceType
  {
    get => _SourceType ??= GetProperty<SourceType?>(GetUpdatableElement()?.SourceType);
    set => UpdateField(ref _SourceType, value, nameof(SourceType));
  }

  private SourceType? _SourceType;

  /// <summary>
  ///   Gets or sets the title of the source.
  /// </summary>
  [OpenXmlProperty(nameof(DXB.Source.Title))]
  public string? Title
  {
    get => _Title ??= GetProperty<string?>(GetUpdatableElement()?.Title);
    set => UpdateField(ref _Title, value, nameof(Title));
  }

  private string? _Title;

  /// <summary>
  ///   Gets or sets the author(s) of the source.
  /// </summary>
  public Contributors? Authors { get => _Authors; set => UpdateField(ref _Authors, value, nameof(Authors)); }

  private Contributors? _Authors;

  /// <summary>
  ///   Gets or sets the editor(s) of the source.
  /// </summary>
  public Contributors? Editors { get => _Editors; set => UpdateField(ref _Editors, value, nameof(Editors)); }

  private Contributors? _Editors;

  /// <summary>
  ///   Gets or sets additional contributors (translators, compilers, etc.).
  /// </summary>
  public Contributors? Contributors
  {
    get => _Contributors;
    set => UpdateField(ref _Contributors, value, nameof(Contributors));
  }

  private Contributors? _Contributors;

  /// <summary>
  ///   Gets or sets the year of publication.
  /// </summary>
  [OpenXmlProperty(nameof(DXB.Source.Year))]
  public string? Year
  {
    get => _Year ??= GetProperty<string?>(GetUpdatableElement()?.Year);
    set => UpdateField(ref _Year, value, nameof(Year));
  }

  private string? _Year;

  /// <summary>
  ///   Gets or sets the month of publication.
  /// </summary>
  [OpenXmlProperty(nameof(DXB.Source.Month))]
  public string? Month
  {
    get => _Month ??= GetProperty<string?>(GetUpdatableElement()?.Month);
    set => UpdateField(ref _Month, value, nameof(Month));
  }

  private string? _Month;

  /// <summary>
  ///   Gets or sets the day of publication.
  /// </summary>
  [OpenXmlProperty(nameof(DXB.Source.Day))]
  public string? Day
  {
    get => _Day ??= GetProperty<string?>(GetUpdatableElement()?.Day);
    set => UpdateField(ref _Day, value, nameof(Day));
  }

  private string? _Day;

  /// <summary>
  ///   Gets or sets the publisher name.
  /// </summary>
  [OpenXmlProperty(nameof(DXB.Source.Publisher))]
  public string? Publisher
  {
    get => _Publisher ??= GetProperty<string?>(GetUpdatableElement()?.Publisher);
    set => UpdateField(ref _Publisher, value, nameof(Publisher));
  }

  private string? _Publisher;

  /// <summary>
  ///   Gets or sets the city of publication.
  /// </summary>
  [OpenXmlProperty(nameof(DXB.Source.City))]
  public string? City
  {
    get => _City ??= GetProperty<string?>(GetUpdatableElement()?.City);
    set => UpdateField(ref _City, value, nameof(City));
  }

  private string? _City;

  /// <summary>
  ///   Gets or sets the state or province of publication.
  /// </summary>
  [OpenXmlProperty(nameof(DXB.Source.StateProvince))]
  public string? StateProvince
  {
    get => _StateProvince ??= GetProperty<string?>(GetUpdatableElement()?.StateProvince);
    set => UpdateField(ref _StateProvince, value, nameof(StateProvince));
  }

  private string? _StateProvince;

  /// <summary>
  ///   Gets or sets the country or region of publication.
  /// </summary>
  [OpenXmlProperty(nameof(DXB.Source.CountryRegion))]
  public string? CountryRegion
  {
    get => _CountryRegion ??= GetProperty<string?>(GetUpdatableElement()?.CountryRegion);
    set => UpdateField(ref _CountryRegion, value, nameof(CountryRegion));
  }

  private string? _CountryRegion;

  /// <summary>
  ///   Gets or sets the volume number (for journals, series, etc.).
  /// </summary>
  [OpenXmlProperty(nameof(DXB.Source.Volume))]
  public string? Volume
  {
    get => _Volume ??= GetProperty<string?>(GetUpdatableElement()?.Volume);
    set => UpdateField(ref _Volume, value, nameof(Volume));
  }

  private string? _Volume;

  /// <summary>
  ///   Gets or sets the issue number (for journals).
  /// </summary>
  [OpenXmlProperty(nameof(DXB.Source.Issue))]
  public string? Issue
  {
    get => _Issue ??= GetProperty<string?>(GetUpdatableElement()?.Issue);
    set => UpdateField(ref _Issue, value, nameof(Issue));
  }

  private string? _Issue;

  /// <summary>
  ///   Gets or sets the page range.
  /// </summary>
  [OpenXmlProperty(nameof(DXB.Source.Pages))]
  public string? Pages
  {
    get => _Pages ??= GetProperty<string?>(GetUpdatableElement()?.Pages);
    set => UpdateField(ref _Pages, value, nameof(Pages));
  }

  private string? _Pages;

  /// <summary>
  ///   Gets or sets the edition information.
  /// </summary>
  [OpenXmlProperty(nameof(DXB.Source.Edition))]
  public string? Edition
  {
    get => _Edition ??= GetProperty<string?>(GetUpdatableElement()?.Edition);
    set => UpdateField(ref _Edition, value, nameof(Edition));
  }

  private string? _Edition;

  /// <summary>
  ///   Gets or sets the URL for electronic sources.
  /// </summary>
  public string? Url { get => _Url; set => UpdateField(ref _Url, value, nameof(Url)); }

  private string? _Url;

  /// <summary>
  ///   Gets or sets the date the source was accessed (for electronic sources).
  /// </summary>
  public DateTime? AccessDate { get => _AccessDate; set => UpdateField(ref _AccessDate, value, nameof(AccessDate)); }

  private DateTime? _AccessDate;

  /// <summary>
  ///   Gets or sets the DOI (Digital Object Identifier).
  /// </summary>
  public string? DOI { get => _DOI; set => UpdateField(ref _DOI, value, nameof(DOI)); }

  private string? _DOI;

  /// <summary>
  ///   Gets or sets the ISBN (International Standard Book Number).
  /// </summary>
  public string? ISBN { get => _ISBN; set => UpdateField(ref _ISBN, value, nameof(ISBN)); }

  private string? _ISBN;

  /// <summary>
  ///   Gets or sets the ISSN (International Standard Serial Number).
  /// </summary>
  public string? ISSN { get => _ISSN; set => UpdateField(ref _ISSN, value, nameof(ISSN)); }

  private string? _ISSN;

  /// <summary>
  ///   Gets or sets the abstract or summary.
  /// </summary>
  public string? Abstract { get => _Abstract; set => UpdateField(ref _Abstract, value, nameof(Abstract)); }

  private string? _Abstract;

  /// <summary>
  ///   Gets or sets additional comments or notes.
  /// </summary>
  [OpenXmlProperty(nameof(DXB.Source.Comments))]
  public string? Comments
  {
    get => _Comments ??= GetProperty<string?>(GetUpdatableElement()?.Comments);
    set => UpdateField(ref _Comments, value, nameof(Comments));
  }

  private string? _Comments;

  /// <summary>
  ///   Gets or sets keywords or tags associated with the source.
  /// </summary>
  public string? Keywords { get => _Keywords; set => UpdateField(ref _Keywords, value, nameof(Keywords)); }

  private string? _Keywords;

  /// <summary>
  ///   Gets or sets the language of the source.
  /// </summary>
  public string? Language { get => _Language; set => UpdateField(ref _Language, value, nameof(Language)); }

  private string? _Language;

  /// <summary>
  ///   Gets or sets whether this source is a corporate author.
  /// </summary>
  public bool IsCorporateAuthor
  {
    get => _IsCorporateAuthor;
    set => UpdateField(ref _IsCorporateAuthor, value, nameof(IsCorporateAuthor));
  }

  private bool _IsCorporateAuthor;

  /// <summary>
  ///   Gets or sets the XML representation of the source.
  /// </summary>
  public string? Xml { get => _Xml; set => UpdateField(ref _Xml, value, nameof(Xml)); }

  private string? _Xml;
}