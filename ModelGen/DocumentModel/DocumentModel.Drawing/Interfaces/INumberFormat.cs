namespace DocumentModel.Drawing;

/// <summary>
/// Defines the NumberFormat Class.
/// </summary>
public interface INumberFormat // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// formatCode, this property is only available in Office 2016 and later.
  /// </summary>
  public System.String? FormatCode { get ; set; }
  
  /// <summary>
  /// sourceLinked, this property is only available in Office 2016 and later.
  /// </summary>
  public System.Boolean? SourceLinked { get ; set; }
  
}
