namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Whole E2O Formatting.
/// </summary>
public interface IWhole // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Outline.
  /// </summary>
  public DocumentModel.Drawing.ILinePropertiesType? Outline { get ; set; }
  
}
