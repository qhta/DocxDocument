namespace DocumentModel.Office2013.Drawing.ChartStyle;

/// <summary>
/// Defines the StyleReference Class.
/// </summary>
public interface IStyleReference // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// idx, this property is only available in Office 2013 and later.
  /// </summary>
  public UInt32? Index { get ; set; }
  
  /// <summary>
  /// mods, this property is only available in Office 2013 and later.
  /// </summary>
  public IListValue<DocumentFormat.OpenXml.StringValue>? Modifiers { get ; set; }
  
}
