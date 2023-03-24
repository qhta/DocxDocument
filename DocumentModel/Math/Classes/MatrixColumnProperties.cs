namespace DocumentModel.Math;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Matrix Column Properties.
/// </summary>
public class MatrixColumnProperties: ModelElement
{
  /// <summary>
  ///   Matrix Column Count.
  /// </summary>
  public Int64? MatrixColumnCount { get; set; }

  /// <summary>
  ///   Matrix Column Justification.
  /// </summary>
  public HorizontalAlignmentKind? MatrixColumnJustification { get; set; }
}