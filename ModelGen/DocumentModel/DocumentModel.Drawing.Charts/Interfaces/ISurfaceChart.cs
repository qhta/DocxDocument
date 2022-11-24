namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Surface Charts.
/// </summary>
public interface ISurfaceChart // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Wireframe.
  /// </summary>
  public IWireframe? Wireframe { get ; set; }
  
}
