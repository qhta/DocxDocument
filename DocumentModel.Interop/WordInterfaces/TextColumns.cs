namespace DocumentModel.Interop;

/// <summary>
/// A collection of TextColumn objects that represent all the columns of text in a document or a section of a document.
/// </summary>
public partial interface TextColumns : InteropObject, InteropCollection<TextColumn>
{
  /// <summary>
  /// The evenly spaced.
  /// </summary>
  public int EvenlySpaced { get; set; }

  /// <summary>
  /// The line between.
  /// </summary>
  public int LineBetween { get; set; }

  /// <summary>
  /// The width.
  /// </summary>
  public float Width { get; set; }

  /// <summary>
  /// The spacing.
  /// </summary>
  public float Spacing { get; set; }

  /// <summary>
  /// The flow direction.
  /// </summary>
  public WdFlowDirection FlowDirection { get; set; }
}
