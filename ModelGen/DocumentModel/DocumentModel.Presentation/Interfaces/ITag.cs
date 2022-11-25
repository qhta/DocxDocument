namespace DocumentModel.Presentation;

/// <summary>
/// Programmable Extensibility Tag.
/// </summary>
public interface ITag // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Name
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// Value
  /// </summary>
  public System.String? Val { get ; set; }
  
}
