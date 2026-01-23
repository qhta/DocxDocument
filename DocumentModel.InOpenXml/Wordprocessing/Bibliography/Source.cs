namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents a bibliographic source (reference).
/// </summary>
public class Source: ModelElement<DXB.Source>
{
  /// <summary>
  ///   Gets or sets the unique identifier (tag) for the source.
  /// </summary>
  public string? Tag { get; set; }

  /// <summary>
  ///   Gets or sets the type of source (book, journal article, website, etc.).
  /// </summary>
  public SourceTypeKind? SourceType { get; set; }

  /// <summary>
  ///   Gets or sets the title of the source.
  /// </summary>
  public string? Title { get; set; }

  /// <summary>
  ///   Gets or sets the author(s) of the source.
  /// </summary>
  public Contributors? Authors { get; set; }

  /// <summary>
  ///   Gets or sets the editor(s) of the source.
  /// </summary>
  public Contributors? Editors { get; set; }

  /// <summary>
  ///   Gets or sets additional contributors (translators, compilers, etc.).
  /// </summary>
  public Contributors? Contributors { get; set; }

  /// <summary>
  ///   Gets or sets the year of publication.
  /// </summary>
  public string? Year { get; set; }

  /// <summary>
  ///   Gets or sets the month of publication.
  /// </summary>
  public string? Month { get; set; }

  /// <summary>
  ///   Gets or sets the day of publication.
  /// </summary>
  public string? Day { get; set; }

  /// <summary>
  ///   Gets or sets the publisher name.
  /// </summary>
  public string? Publisher { get; set; }

  /// <summary>
  ///   Gets or sets the city of publication.
  /// </summary>
  public string? City { get; set; }

  /// <summary>
  ///   Gets or sets the state or province of publication.
  /// </summary>
  public string? StateProvince { get; set; }

  /// <summary>
  ///   Gets or sets the country or region of publication.
  /// </summary>
  public string? CountryRegion { get; set; }

  /// <summary>
  ///   Gets or sets the volume number (for journals, series, etc.).
  /// </summary>
  public string? Volume { get; set; }

  /// <summary>
  ///   Gets or sets the issue number (for journals).
  /// </summary>
  public string? Issue { get; set; }

  /// <summary>
  ///   Gets or sets the page range.
  /// </summary>
  public string? Pages { get; set; }

  /// <summary>
  ///   Gets or sets the edition information.
  /// </summary>
  public string? Edition { get; set; }

  /// <summary>
  ///   Gets or sets the URL for electronic sources.
  /// </summary>
  public string? Url { get; set; }

  /// <summary>
  ///   Gets or sets the date the source was accessed (for electronic sources).
  /// </summary>
  public DateTime? AccessDate { get; set; }

  /// <summary>
  ///   Gets or sets the DOI (Digital Object Identifier).
  /// </summary>
  public string? DOI { get; set; }

  /// <summary>
  ///   Gets or sets the ISBN (International Standard Book Number).
  /// </summary>
  public string? ISBN { get; set; }

  /// <summary>
  ///   Gets or sets the ISSN (International Standard Serial Number).
  /// </summary>
  public string? ISSN { get; set; }

  /// <summary>
  ///   Gets or sets the abstract or summary.
  /// </summary>
  public string? Abstract { get; set; }

  /// <summary>
  ///   Gets or sets additional comments or notes.
  /// </summary>
  public string? Comments { get; set; }

  /// <summary>
  ///   Gets or sets keywords or tags associated with the source.
  /// </summary>
  public string? Keywords { get; set; }

  /// <summary>
  ///   Gets or sets the language of the source.
  /// </summary>
  public string? Language { get; set; }

  /// <summary>
  ///   Gets or sets whether this source is a corporate author.
  /// </summary>
  public bool IsCorporateAuthor { get; set; }

  /// <summary>
  ///   Gets or sets the XML representation of the source.
  /// </summary>
  public string? Xml { get; set; }
}