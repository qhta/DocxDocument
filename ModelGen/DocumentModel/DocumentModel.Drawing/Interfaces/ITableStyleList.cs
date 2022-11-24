namespace DocumentModel.Drawing;

/// <summary>
/// Table Style List.
/// </summary>
public interface ITableStyleList // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// Default
  /// </summary>
  public String? Default { get ; set; }
  
  /// <summary>
  /// Gets the TableStylesPart associated with this element.
  /// </summary>
  public TableStylesPart? TableStylesPart { get ; set; }
  
}
