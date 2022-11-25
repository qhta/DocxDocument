namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ThemeableLineStyleType Class.
/// </summary>
public interface IThemeableLineStyleType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Outline.
  /// </summary>
  public DocumentModel.Drawing.ILinePropertiesType? Outline { get ; set; }
  
  /// <summary>
  /// Line Reference.
  /// </summary>
  public DocumentModel.Drawing.IStyleMatrixReferenceType? LineReference { get ; set; }
  
}
