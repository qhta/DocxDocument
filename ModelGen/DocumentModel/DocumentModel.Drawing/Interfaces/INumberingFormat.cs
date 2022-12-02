namespace DocumentModel.Drawing;

/// <summary>
/// Defines the NumberingFormat Class.
/// </summary>
public interface INumberingFormat // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Number Format Code
  /// </summary>
  public String? FormatCode { get ; set; }
  
  /// <summary>
  /// Linked to Source
  /// </summary>
  public Boolean? SourceLinked { get ; set; }
  
}
