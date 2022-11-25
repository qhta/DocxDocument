namespace DocumentModel.Office2013.Drawing.ChartStyle;

/// <summary>
/// Defines the FontReference Class.
/// </summary>
public interface IFontReference // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// idx, this property is only available in Office 2013 and later.
  /// </summary>
  public DocumentModel.Drawing.FontCollectionIndexKind? Index { get ; set; }
  
  /// <summary>
  /// mods, this property is only available in Office 2013 and later.
  /// </summary>
  public System.Collections.Generic.List<System.String>? Modifiers { get ; set; }
  
}
