namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Number Format.
/// </summary>
public interface INumberingFormat // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Number Format Code
  /// </summary>
  public System.String? FormatCode { get ; set; }
  
  /// <summary>
  /// Linked to Source
  /// </summary>
  public System.Boolean? SourceLinked { get ; set; }
  
}
