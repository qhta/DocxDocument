namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ThemeableLineStyleType Class.
/// </summary>
public interface IThemeableLineStyleType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Outline.
  /// </summary>
  public IOutline? Outline { get ; set; }
  
  /// <summary>
  /// Line Reference.
  /// </summary>
  public ILineReference? LineReference { get ; set; }
  
}
