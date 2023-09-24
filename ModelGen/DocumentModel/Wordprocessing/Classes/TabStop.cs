namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies a single custom tab stop defined within a set of paragraph properties in a document. A tab stop location shall always be measured relative to the leading edge of the paragraph in which it is used (that is, the left edge for a left-to-right paragraph, and the right edge for a right-to-left paragraph).
/// </summary>
public partial class TabStop
{
  
  /// <summary>
  ///   Tab Stop Type
  /// </summary>
  public TabStopKind? Val { get; set; }
  
  
  /// <summary>
  ///   Tab Leader Character
  /// </summary>
  public TabStopLeaderCharKind? Leader { get; set; }
  
  
  /// <summary>
  ///   Tab Stop Position
  /// </summary>
  public Int32? Position { get; set; }
  
}
