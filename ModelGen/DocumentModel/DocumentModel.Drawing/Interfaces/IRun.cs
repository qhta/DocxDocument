namespace DocumentModel.Drawing;

/// <summary>
/// Text Run.
/// </summary>
public interface IRun // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Text Character Properties.
  /// </summary>
  public IRunProperties? RunProperties { get ; set; }
  
  /// <summary>
  /// Text String.
  /// </summary>
  public IText? Text { get ; set; }
  
}
