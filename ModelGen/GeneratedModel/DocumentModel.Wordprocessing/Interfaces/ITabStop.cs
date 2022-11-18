namespace DocumentModel.Wordprocessing;

/// <summary>
/// Custom Tab Stop.
/// </summary>
public interface ITabStop // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Tab Stop Type
  /// </summary>
  public TabStop? Val { get ; set; }
  
  /// <summary>
  /// Tab Leader Character
  /// </summary>
  public TabStopLeaderChar? Leader { get ; set; }
  
  /// <summary>
  /// Tab Stop Position
  /// </summary>
  public int? Position { get ; set; }
  
}
