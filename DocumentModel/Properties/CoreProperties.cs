namespace DocumentModel;

/// <summary>
///   Collection of core properties, which represents document properties defined in Dublin Core standard
  /// and Open Packaging Conventions
/// </summary>
public partial class CoreProperties: KnownDocumentProperties
{
  /// <summary>
  ///   The topic of the content of the resource.
  /// </summary>
  public string? Title { get; set; }

  /// <summary>
  ///   The topic of the content of the resource.
  /// </summary>
  public string? Subject { get; set; }

  /// <summary>
  ///   An entity primarily responsible for making the content of the resource.
  /// </summary>
  public string? Creator { get; set; }

  /// <summary>
  ///   A delimited set of keywords to support searching and indexing. 
  ///   This is typically a list of terms that are not available elsewhere in the properties. 
  ///   The definition of this element uniquely allows for: 
  ///   Use of the xml:lang attribute to identify languages 
  ///   A mixed content model, such that keywords can be flagged individually 
  /// </summary>
  public string? Keywords { get; set; }

  /// <summary>
  ///   An explanation of the content of the resource. [Example: Values might include 
  ///   an abstract, table of contents, reference to a graphical representation of content, 
  ///   and a free-text account of the content. 
  /// </summary>
  public string? Description { get; set; }

  /// <summary>
  ///   The user who performed the last modification. The identification is environment-specific. 
  ///   A name, email address, or employee ID. It is recommended that this value be as concise as possible.
  /// </summary>
  public string? LastModifiedBy { get; set; }

  /// <summary>
  ///   The revision number. This value might indicate the number of saves or revisions, 
  ///   provided the application updates it after each revision.
  /// </summary>
  public int? Revision { get; set; }

  /// <summary>
  ///   The date and time of the last printing.
  /// </summary>
  public DateTime? LastPrinted { get; set; }

  /// <summary>
  ///   Date of creation of the resource.
  /// </summary>
  public DateTime? Created { get; set; }

  /// <summary>
  ///   The date and time of the last modification.
  /// </summary>
  public DateTime? Modified { get; set; }

  /// <summary>
  ///   A categorization of the content of this package. 
  ///   Example values for this property might include: 
  ///   Resume, Letter, Financial Forecast, Proposal, Technical Presentation, and so on. T
  ///   his value might be used by an application's user interface to facilitate navigation of a large set of documents.
  /// </summary>
  public string? Category { get; set; }

  /// <summary>
  ///   An unambiguous reference to the resource within a given context.
  /// </summary>
  public string? Identifier { get; set; }

  /// <summary>
  ///   The type of content represented, generally defined by a specific
  /// </summary>
  public string? ContentType { get; set; }

  /// <summary>
  ///   The language of the intellectual content of the resource. 
  ///   IETF RFC 3066 provides guidance on encoding to represent languages. 
  /// </summary>
  public string? Language { get; set; }

  /// <summary>
  ///   The version number. This value is set by the user or by the application.
  /// </summary>
  public string? Version { get; set; }

  /// <summary>
  ///   The status of the content. Values might include “Draft”, “Reviewed”, and “Final”.
  /// </summary>
  public string? ContentStatus { get; set; }
}