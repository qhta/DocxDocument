namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Style Label Description.
/// </summary>
public interface IStyleLabelDescription // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Natural Language
  /// </summary>
  public System.String? Language { get ; set; }
  
  /// <summary>
  /// Description Value
  /// </summary>
  public System.String? Val { get ; set; }
  
}
