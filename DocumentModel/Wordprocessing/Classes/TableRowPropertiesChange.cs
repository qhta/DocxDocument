namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Revision Information for Table Row Properties.
/// </summary>
public class TableRowPropertiesChange: ModelElement
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
  ///   Previous Table Row Properties.
  /// </summary>
  public PreviousTableRowProperties? PreviousTableRowProperties { get; set; }
}