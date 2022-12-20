namespace DocxDocument.Model;

public interface ICoreDocumentProperties
{
  /// <summary>
  /// The title of the document.
  /// </summary>
  public string? Title { get; set; }

  /// <summary>
  /// The topic of the contents.
  /// </summary>
  public string? Subject { get; set; }

  /// <summary>
  /// The primary creator. The identification is environment-specific and
  /// can consist of a name, email address, employee ID, etc. It is
  /// recommended that this value be only as verbose as necessary to
  /// identify the individual.
  /// </summary>
  public string? Creator { get; set; }

  /// <summary>
  /// A delimited set of keywords to support searching and indexing. This
  /// is typically a list of terms that are not available elsewhere in the
  /// properties.
  /// </summary>
  public string? Keywords { get; set; }

  /// <summary>
  /// The description or of the contents.
  /// </summary>
  public string? Description { get; set; }

  /// <summary>
  /// The user who performed the last modification. The identification is
  /// environment-specific and can consist of a name, email address,
  /// employee ID, etc. It is recommended that this value be only as
  /// verbose as necessary to identify the individual.
  /// </summary>
  public string? LastModifiedBy { get; set; }

  /// <summary>
  /// The revision number. This value indicates the number of saves or
  /// revisions. The application is responsible for updating this value
  /// after each revision.
  /// </summary>
  public string? Revision { get; set; }

  /// <summary>
  /// The date and time of the last printing.
  /// </summary>
  public DateTime? LastPrinted { get; set; }

  /// <summary>
  /// The creation date and time.
  /// </summary>
  public DateTime? Created { get; set; }

  /// <summary>
  /// The date and time of the last modification.
  /// </summary>
  public DateTime? LastModified { get; set; }

  /// <summary>
  /// The Category value is typically used as part of the application
  /// user interface (UI) to create labels for navigation controls.
  /// </summary>
  public string? Category { get; set; }

  /// <summary>
  /// Example ContentStatus values include "Draft", "Reviewed", and "Final".
  /// </summary>
  public string? ContentStatus { get; set; }

  /// <summary>
  /// Gets or sets a value that unambiguously identifies the Package and its content.
  /// </summary>
  public string? Identifier { get; set; }

  /// <summary>
  /// Gets or sets a value that represents the type of content that is contained in the Package.
  /// </summary>
  public string? ContentType { get; set; }

  /// <summary>
  /// Gets or sets the revision number of the Package.
  /// </summary>
  public string? Version { get; set; }

  /// <summary>
  /// Gets or sets the language of the Package.
  /// </summary>
  public string? Language { get; set; }
}