namespace DocumentModel;

/// <summary>
///   This class provides access to the "core properties", such as Title and
/// </summary>
public partial class CoreProperties: KnownDocumentProperties
{
  /// <summary>
  ///   The title.
  /// </summary>
  public String? Title { get; set; }

  /// <summary>
  ///   The topic of the contents.
  /// </summary>
  public String? Subject { get; set; }

  /// <summary>
  ///   The primary creator. The identification is environment-specific and
  /// </summary>
  public String? Creator { get; set; }

  /// <summary>
  ///   A delimited set of keywords to support searching and indexing. This
  /// </summary>
  public String? Keywords { get; set; }

  /// <summary>
  ///   The description or abstract of the contents.
  /// </summary>
  public String? Description { get; set; }

  /// <summary>
  ///   The user who performed the last modification. The identification is
  /// </summary>
  public String? LastModifiedBy { get; set; }

  /// <summary>
  ///   The revision number. This value indicates the number of saves or
  /// </summary>
  public String? Revision { get; set; }

  /// <summary>
  ///   The date and time of the last printing.
  /// </summary>
  public DateTime? LastPrinted { get; set; }

  /// <summary>
  ///   The creation date and time.
  /// </summary>
  public DateTime? Created { get; set; }

  /// <summary>
  ///   The date and time of the last modification.
  /// </summary>
  public DateTime? Modified { get; set; }

  /// <summary>
  ///   The category. This value is typically used by UI applications to create navigation
  /// </summary>
  public String? Category { get; set; }

  /// <summary>
  ///   A unique identifier.
  /// </summary>
  public String? Identifier { get; set; }

  /// <summary>
  ///   The type of content represented, generally defined by a specific
  /// </summary>
  public String? ContentType { get; set; }

  /// <summary>
  ///   The primary language of the package content. The language tag is
  /// </summary>
  public String? Language { get; set; }

  /// <summary>
  ///   The version number. This value is set by the user or by the application.
  /// </summary>
  public String? Version { get; set; }

  /// <summary>
  ///   The status of the content. Example values include "Draft",
  /// </summary>
  public String? ContentStatus { get; set; }
}