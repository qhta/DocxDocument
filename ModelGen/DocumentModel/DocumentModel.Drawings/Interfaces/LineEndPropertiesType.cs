namespace DocumentModel.Drawings;

/// <summary>
/// Defines the LineEndPropertiesType Class.
/// </summary>
public interface LineEndPropertiesType
{
  /// <summary>
  /// Line Head/End Type
  /// </summary>
  public DocumentModel.Drawings.LineEndKind? Type { get ; set; }
  
  /// <summary>
  /// Width of Head/End
  /// </summary>
  public DocumentModel.Drawings.LineEndWidthKind? Width { get ; set; }
  
  /// <summary>
  /// Length of Head/End
  /// </summary>
  public DocumentModel.Drawings.LineEndLengthKind? Length { get ; set; }
  
}
