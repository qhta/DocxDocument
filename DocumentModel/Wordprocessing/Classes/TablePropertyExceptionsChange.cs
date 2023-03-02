namespace DocumentModel.Wordprocessing;

/// <summary>
///   Revision Information for Table-Level Property Exceptions.
/// </summary>
public record TablePropertyExceptionsChange
{
  /// <summary>
  ///   author
  /// </summary>
  public String? Author { get; set; }

  /// <summary>
  ///   date
  /// </summary>
  public DateTime? Date { get; set; }

  /// <summary>
  ///   Annotation Identifier
  /// </summary>
  public String? Id { get; set; }

  /// <summary>
  ///   Previous Table-Level Property Exceptions.
  /// </summary>
  public PreviousTablePropertyExceptions? PreviousTablePropertyExceptions { get; set; }
}