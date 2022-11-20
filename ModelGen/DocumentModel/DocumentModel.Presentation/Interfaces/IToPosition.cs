namespace DocumentModel.Presentation;

/// <summary>
/// Defines the ToPosition Class.
/// </summary>
public interface IToPosition // : DocumentFormat.OpenXml.Presentation.TimeListType
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
