namespace DocxDocument.Model;

public interface ICoreDocumentProperties
{
  /// <summary>
  /// The title of the document.
  /// </summary>
  string Title { get; set; }

  /// <summary>
  /// The topic of the contents.
  /// </summary>
  string Subject { get; set; }

  /// <summary>
  /// The primary creator. The identification is environment-specific and
  /// can consist of a name, email address, employee ID, etc. It is
  /// recommended that this value be only as verbose as necessary to
  /// identify the individual.
  /// </summary>
  string Creator { get; set; }

  /// <summary>
  /// A delimited set of keywords to support searching and indexing. This
  /// is typically a list of terms that are not available elsewhere in the
  /// properties.
  /// </summary>
  string Keywords { get; set; }

  /// <summary>
  /// The description or of the contents.
  /// </summary>
  string Description { get; set; }

  /// <summary>
  /// The user who performed the last modification. The identification is
  /// environment-specific and can consist of a name, email address,
  /// employee ID, etc. It is recommended that this value be only as
  /// verbose as necessary to identify the individual.
  /// </summary>
  string LastModifiedBy { get; set; }

  /// <summary>
  /// The revision number. This value indicates the number of saves or
  /// revisions. The application is responsible for updating this value
  /// after each revision.
  /// </summary>
  string Revision { get; set; }

  /// <summary>
  /// The date and time of the last printing.
  /// </summary>
  DateTime? LastPrinted { get; set; }

  /// <summary>
  /// The creation date and time.
  /// </summary>
  DateTime? Created { get; set; }

  /// <summary>
  /// The date and time of the last modification.
  /// </summary>
  DateTime? LastModified { get; set; }

  /// <summary>
  /// The Category value is typically used as part of the application
  /// user interface (UI) to create labels for navigation controls.
  /// </summary>
  string? Category { get; set; }

  /// <summary>
  /// Example ContentStatus values include "Draft", "Reviewed", and "Final".
  /// </summary>
  string? ContentStatus { get; set; }

}