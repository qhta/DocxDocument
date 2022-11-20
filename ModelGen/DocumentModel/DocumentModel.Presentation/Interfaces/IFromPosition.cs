namespace DocumentModel.Presentation;

/// <summary>
/// Defines the FromPosition Class.
/// </summary>
public interface IFromPosition // : DocumentFormat.OpenXml.Presentation.TimeListType
{
  /// <summary>
  /// X coordinate
  /// </summary>
  public int? X { get ; set; }
  
  /// <summary>
  /// Y coordinate
  /// </summary>
  public int? Y { get ; set; }
  
}
