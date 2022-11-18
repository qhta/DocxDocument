namespace DocumentModel.Presentation;

/// <summary>
/// Defines the ByPosition Class.
/// </summary>
public interface IByPosition // : DocumentFormat.OpenXml.Presentation.TimeListType
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
