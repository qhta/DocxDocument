namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the ExternalData Class.
/// </summary>
public interface IExternalData // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Relationship Reference
  /// </summary>
  public String? Id { get ; set; }
  
  /// <summary>
  /// Update Automatically.
  /// </summary>
  public IAutoUpdate? AutoUpdate { get ; set; }
  
}
