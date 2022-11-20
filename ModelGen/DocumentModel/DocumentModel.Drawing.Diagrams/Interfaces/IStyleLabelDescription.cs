namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Style Label Description.
/// </summary>
public interface IStyleLabelDescription // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
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
