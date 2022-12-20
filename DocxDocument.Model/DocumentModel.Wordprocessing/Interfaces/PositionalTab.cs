namespace DocumentModel.Wordprocessing;

/// <summary>
/// Absolute Position Tab Character.
/// </summary>
public partial interface PositionalTab
{
  /// <summary>
  /// Positional Tab Stop Alignment
  /// </summary>
  public DocumentModel.Wordprocessing.AbsolutePositionTabAlignmentKind? Alignment { get; set; }
  
  /// <summary>
  /// Positional Tab Base
  /// </summary>
  public DocumentModel.Wordprocessing.AbsolutePositionTabPositioningBaseKind? RelativeTo { get; set; }
  
  /// <summary>
  /// Tab Leader Character
  /// </summary>
  public DocumentModel.Wordprocessing.AbsolutePositionTabLeaderCharKind? Leader { get; set; }
  
}
