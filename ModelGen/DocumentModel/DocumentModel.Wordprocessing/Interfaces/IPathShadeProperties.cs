namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the PathShadeProperties Class.
/// </summary>
public interface IPathShadeProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// path, this property is only available in Office 2010 and later.
  /// </summary>
  public PathShadeKind? Path { get ; set; }
  
  /// <summary>
  /// FillToRectangle.
  /// </summary>
  public IFillToRectangle? FillToRectangle { get ; set; }
  
}
