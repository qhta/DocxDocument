namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that an absolute position tab character shall be placed at the current location in the run content. An absolute position tab is a character which is used to advance the position on the current line of text when displaying this WordprocessingML content, using the following logic:
/// </summary>
public partial class PositionalTab
{
  
  /// <summary>
  ///   Positional Tab Stop Alignment
  /// </summary>
  public DocumentModel.Wordprocessing.AbsolutePositionTabAlignmentKind? Alignment { get; set; }
  
  
  /// <summary>
  ///   Positional Tab Base
  /// </summary>
  public DocumentModel.Wordprocessing.AbsolutePositionTabPositioningBaseKind? RelativeTo { get; set; }
  
  
  /// <summary>
  ///   Tab Leader Character
  /// </summary>
  public DocumentModel.Wordprocessing.AbsolutePositionTabLeaderCharKind? Leader { get; set; }
  
}
