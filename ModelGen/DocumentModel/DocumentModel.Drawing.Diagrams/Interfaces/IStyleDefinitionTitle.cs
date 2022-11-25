namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Title.
/// </summary>
public interface IStyleDefinitionTitle // : DocumentModel.ITypedOpenXmlLeafElement
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
