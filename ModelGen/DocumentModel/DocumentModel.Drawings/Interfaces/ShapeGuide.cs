namespace DocumentModel.Drawings;

/// <summary>
/// Shape Guide.
/// </summary>
public interface ShapeGuide // : System.Boolean
{
  /// <summary>
  /// Shape Guide Name
  /// </summary>
  public String? Name { get ; set; }
  
  /// <summary>
  /// Shape Guide Formula
  /// </summary>
  public String? Formula { get ; set; }
  
}
