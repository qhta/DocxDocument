namespace DocumentModel.Office2013.Drawing.ChartStyle;

/// <summary>
/// Defines the StyleColor Class.
/// </summary>
public interface IStyleColor // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// val, this property is only available in Office 2013 and later.
  /// </summary>
  public String? Val { get ; set; }
  
}
