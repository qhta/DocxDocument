namespace DocumentModel.Wordprocessing;

/// <summary>
///   Absolute Position Tab Character.
/// </summary>
public class PositionalTab
{
  /// <summary>
  ///   Positional Tab Stop Alignment
  /// </summary>
  public AbsolutePositionTabAlignmentKind? Alignment { get; set; }

  /// <summary>
  ///   Positional Tab Base
  /// </summary>
  public AbsolutePositionTabPositioningBaseKind? RelativeTo { get; set; }

  /// <summary>
  ///   Tab Leader Character
  /// </summary>
  public AbsolutePositionTabLeaderCharKind? Leader { get; set; }
}