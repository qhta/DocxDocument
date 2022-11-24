namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Title.
/// </summary>
public interface IStyleDefinitionTitle // : DocumentModel.ITypedOpenXmlLeafElement
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
