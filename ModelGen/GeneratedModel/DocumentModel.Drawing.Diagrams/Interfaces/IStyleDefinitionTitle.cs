namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Title.
/// </summary>
public interface IStyleDefinitionTitle // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Natural Language
  /// </summary>
  public string? Language { get ; set; }
  
  /// <summary>
  /// Description Value
  /// </summary>
  public string? Val { get ; set; }
  
}
