namespace DocumentModel.Wordprocessing;

/// <summary>
/// Entry Name.
/// </summary>
public interface IDocPartName // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Name Value
  /// </summary>
  public System.String? Val { get ; set; }
  
  /// <summary>
  /// Built-In Entry
  /// </summary>
  public System.Boolean? Decorated { get ; set; }
  
}
