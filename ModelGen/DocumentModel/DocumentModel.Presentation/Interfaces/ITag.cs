namespace DocumentModel.Presentation;

/// <summary>
/// Programmable Extensibility Tag.
/// </summary>
public interface ITag // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Name
  /// </summary>
  public String? Name { get ; set; }
  
  /// <summary>
  /// Value
  /// </summary>
  public String? Val { get ; set; }
  
}
