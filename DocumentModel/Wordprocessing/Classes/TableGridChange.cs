namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Revision Information for Table Grid Column Definitions.
/// </summary>
public class TableGridChange: ModelElement
{
  /// <summary>
  ///   Annotation Identifier
  /// </summary>
  public String? Id { get; set; }

  /// <summary>
  ///   Previous Table Grid.
  /// </summary>
  public PreviousTableGrid? PreviousTableGrid { get; set; }
}