namespace DocumentModel.Office2013.Drawing.ChartStyle;

/// <summary>
/// Defines the StyleReference Class.
/// </summary>
public interface IStyleReference // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// idx, this property is only available in Office 2013 and later.
  /// </summary>
  public System.UInt32? Index { get ; set; }
  
  /// <summary>
  /// mods, this property is only available in Office 2013 and later.
  /// </summary>
  public System.Collections.Generic.List<System.String>? Modifiers { get ; set; }
  
}
