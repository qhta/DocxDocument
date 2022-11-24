namespace DocumentModel.Drawing;

/// <summary>
/// Move Path To.
/// </summary>
public interface IMoveTo // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Move end point.
  /// </summary>
  public IPoint? Point { get ; set; }
  
}
