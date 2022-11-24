namespace DocumentModel.InkML;

/// <summary>
/// Defines the Brush Class.
/// </summary>
public interface IBrush // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// id
  /// </summary>
  public String? Id { get ; set; }
  
  /// <summary>
  /// brushRef
  /// </summary>
  public String? BrushRef { get ; set; }
  
}
