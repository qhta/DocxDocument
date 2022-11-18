namespace DocumentModel.Presentation;

/// <summary>
/// Defines the RotationCenter Class.
/// </summary>
public interface IRotationCenter // : DocumentFormat.OpenXml.Presentation.TimeListType
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
