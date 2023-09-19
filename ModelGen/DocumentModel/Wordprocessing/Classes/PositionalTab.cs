namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that an absolute position tab character shall be placed at the current location in the run content. An absolute position tab is a character which is used to advance the position on the current line of text when displaying this WordprocessingML content, using the following logic:
/// </summary>
public partial class PositionalTab
{
  
  /// <summary>
  ///   Positional Tab Stop Alignment
  /// </summary>
  [SchemaAttr("w:alignment")]
  public DocumentModel.Wordprocessing.AbsolutePositionTabAlignmentValues? Alignment { get; set; }
  
  
  /// <summary>
  ///   Positional Tab Base
  /// </summary>
  [SchemaAttr("w:relativeTo")]
  public DocumentModel.Wordprocessing.AbsolutePositionTabPositioningBaseValues? RelativeTo { get; set; }
  
  
  /// <summary>
  ///   Tab Leader Character
  /// </summary>
  [SchemaAttr("w:leader")]
  public DocumentModel.Wordprocessing.AbsolutePositionTabLeaderCharValues? Leader { get; set; }
  
}
