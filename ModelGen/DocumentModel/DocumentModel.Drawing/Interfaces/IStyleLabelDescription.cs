namespace DocumentModel.Drawing;

/// <summary>
/// Style Label Description.
/// </summary>
public interface IStyleLabelDescription // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Natural Language
  /// </summary>
  public String? Language { get ; set; }
  
  /// <summary>
  /// Description Value
  /// </summary>
  public String? Val { get ; set; }
  
}
