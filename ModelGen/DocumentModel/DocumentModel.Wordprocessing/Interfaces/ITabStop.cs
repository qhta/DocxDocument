namespace DocumentModel.Wordprocessing;

/// <summary>
/// Custom Tab Stop.
/// </summary>
public interface ITabStop // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Tab Stop Type
  /// </summary>
  public DocumentModel.Wordprocessing.TabStopKind? Val { get ; set; }
  
  /// <summary>
  /// Tab Leader Character
  /// </summary>
  public DocumentModel.Wordprocessing.TabStopLeaderCharKind? Leader { get ; set; }
  
  /// <summary>
  /// Tab Stop Position
  /// </summary>
  public System.Int32? Position { get ; set; }
  
}
