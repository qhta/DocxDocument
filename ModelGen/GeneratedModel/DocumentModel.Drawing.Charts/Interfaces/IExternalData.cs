namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the ExternalData Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IAutoUpdate))]
public interface IExternalData // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Relationship Reference
  /// </summary>
  public string? Id { get ; set; }
  
  /// <summary>
  /// Update Automatically.
  /// </summary>
  public IAutoUpdate? AutoUpdate { get ; set; }
  
}
