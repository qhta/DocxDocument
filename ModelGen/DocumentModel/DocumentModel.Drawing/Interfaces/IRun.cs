namespace DocumentModel.Drawing;

/// <summary>
/// Text Run.
/// </summary>
public interface IRun // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Text Character Properties.
  /// </summary>
  public DocumentModel.Drawing.IRunProperties? RunProperties { get ; set; }
  
  /// <summary>
  /// Text String.
  /// </summary>
  public System.String? Text { get ; set; }
  
}
