namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   This class provides access to the "core properties", such as Title and
/// </summary>
public partial class CoreProperties: KnownDocumentProperties
{
  /// <summary>
  ///   The title.
  /// </summary>
  public string? Title { get; set; }

  /// <summary>
  ///   The topic of the contents.
  /// </summary>
  public string? Subject { get; set; }

  /// <summary>
  ///   The primary creator. The identification is environment-specific and
  /// </summary>
  public string? Creator { get; set; }

  /// <summary>
  ///   A delimited set of keywords to support searching and indexing. This
  /// </summary>
  public string? Keywords { get; set; }

  /// <summary>
  ///   The description or abstract of the contents.
  /// </summary>
  public string? Description { get; set; }

  /// <summary>
  ///   The user who performed the last modification. The identification is
  /// </summary>
  public string? LastModifiedBy { get; set; }

  /// <summary>
  ///   The revision number. This value indicates the number of saves or
  /// </summary>
  public string? Revision { get; set; }

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
  public string? Category { get; set; }

  /// <summary>
  ///   A unique identifier.
  /// </summary>
  public string? Identifier { get; set; }

  /// <summary>
  ///   The type of content represented, generally defined by a specific
  /// </summary>
  public string? ContentType { get; set; }

  /// <summary>
  ///   The primary language of the package content. The language tag is
  /// </summary>
  public string? Language { get; set; }

  /// <summary>
  ///   The version number. This value is set by the user or by the application.
  /// </summary>
  public string? Version { get; set; }

  /// <summary>
  ///   The status of the content. Example values include "Draft",
  /// </summary>
  public string? ContentStatus { get; set; }
}