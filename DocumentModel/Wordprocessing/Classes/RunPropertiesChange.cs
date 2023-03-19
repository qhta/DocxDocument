namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the RunPropertiesChange Class.
/// </summary>
public class RunPropertiesChange: ModelElement
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
  ///   Previous Run Properties.
  /// </summary>
  public PreviousRunProperties? PreviousRunProperties { get; set; }
}