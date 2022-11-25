namespace DocumentModel.InkML;

/// <summary>
/// Defines the Brush Class.
/// </summary>
public interface IBrush // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// id
  /// </summary>
  public System.String? Id { get ; set; }
  
  /// <summary>
  /// brushRef
  /// </summary>
  public System.String? BrushRef { get ; set; }
  
}
