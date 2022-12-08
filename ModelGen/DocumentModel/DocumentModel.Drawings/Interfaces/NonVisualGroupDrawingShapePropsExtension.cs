namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NonVisualGroupDrawingShapePropsExtension Class.
/// </summary>
public interface NonVisualGroupDrawingShapePropsExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public NonVisualGroupProperties? NonVisualGroupProperties { get ; set; }
  
}
