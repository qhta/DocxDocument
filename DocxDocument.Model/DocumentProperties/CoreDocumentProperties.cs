namespace DocxDocument.Model;

public class CoreDocumentProperties: ICoreDocumentProperties
{
  public CoreDocumentProperties(PackageProperties docxProperties)
  {
    DocxProperties= docxProperties;
  }

  public PackageProperties DocxProperties { get; set; }


  /// <summary>
  /// The title of the document.
  /// </summary>
  public string? Title { get => DocxProperties.Title; set => DocxProperties.Title = value; }

  /// <summary>
  /// The topic of the contents.
  /// </summary>
  public string? Subject { get => DocxProperties.Subject; set => DocxProperties.Subject = value; }

  /// <summary>
  /// The primary creator. The identification is environment-specific and
  /// can consist of a name, email address, employee ID, etc. It is
  /// recommended that this value be only as verbose as necessary to
  /// identify the individual.
  /// </summary>
  public string? Creator { get => DocxProperties.Creator; set => DocxProperties.Creator = value; }

  /// <summary>
  /// A delimited set of keywords to support searching and indexing. This
  /// is typically a list of terms that are not available elsewhere in the
  /// properties.
  /// </summary>
  public string? Keywords { get => DocxProperties.Keywords; set => DocxProperties.Keywords = value; }

  /// <summary>
  /// The description or of the contents.
  /// </summary>
  public string? Description { get => DocxProperties.Description; set => DocxProperties.Description = value; }

  /// <summary>
  /// The user who performed the last modification. The identification is
  /// environment-specific and can consist of a name, email address,
  /// employee ID, etc. It is recommended that this value be only as
  /// verbose as necessary to identify the individual.
  /// </summary>
  public string? LastModifiedBy { get => DocxProperties.LastModifiedBy; set => DocxProperties.LastModifiedBy = value; }

  /// <summary>
  /// The revision number. This value indicates the number of saves or
  /// revisions. The application is responsible for updating this value
  /// after each revision.
  /// </summary>
  public string? Revision { get => DocxProperties.Revision; set => DocxProperties.Revision = value; }

  /// <summary>
  /// The date and time of the last printing.
  /// </summary>
  public DateTime? LastPrinted { get => DocxProperties.LastPrinted; set => DocxProperties.LastPrinted = value; }

  /// <summary>
  /// The creation date and time.
  /// </summary>
  public DateTime? Created { get => DocxProperties.Created; set => DocxProperties.Created = value; }

  /// <summary>
  /// The date and time of the last modification.
  /// </summary>
  public DateTime? LastModified { get => DocxProperties.Modified; set => DocxProperties.Modified = value; }

  /// <summary>
  /// The Category value is typically used as part of the application
  /// user interface (UI) to create labels for navigation controls.
  /// </summary>
  public string? Category { get => DocxProperties.Category; set => DocxProperties.Category = value; }

  /// <summary>
  /// Example ContentStatus values include "Draft", "Reviewed", and "Final".
  /// </summary>
  public string? ContentStatus { get => DocxProperties.ContentStatus; set => DocxProperties.ContentStatus = value; }

  /// <summary>
  /// Gets or sets a value that unambiguously identifies the Package and its content.
  /// </summary>
  public string? Identifier { get => DocxProperties.Identifier; set => DocxProperties.Identifier = value; }

  /// <summary>
  /// Gets or sets a value that represents the type of content that is contained in the Package.
  /// </summary>
  public string? ContentType { get => DocxProperties.ContentType; set => DocxProperties.ContentType = value; }

  /// <summary>
  /// Gets or sets the revision number of the Package.
  /// </summary>
  public string? Version { get => DocxProperties.Version; set => DocxProperties.Version = value; }

  /// <summary>
  /// Gets or sets the language of the Package.
  /// </summary>
  public string? Language { get => DocxProperties.Language; set => DocxProperties.Version = Language; }
}
