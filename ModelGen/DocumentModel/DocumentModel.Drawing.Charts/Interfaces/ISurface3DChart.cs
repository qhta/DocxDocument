namespace DocumentModel.Drawing.Charts;

/// <summary>
/// 3D Surface Charts.
/// </summary>
public interface ISurface3DChart // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Wireframe.
  /// </summary>
  public IWireframe? Wireframe { get ; set; }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public IVaryColors? VaryColors { get ; set; }
  
}
