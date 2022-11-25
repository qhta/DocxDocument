namespace DocumentModel.Wordprocessing;

/// <summary>
/// Single Column Definition.
/// </summary>
public interface IColumn // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Column Width
  /// </summary>
  public System.String? Width { get ; set; }
  
  /// <summary>
  /// Space Before Following Column
  /// </summary>
  public System.String? Space { get ; set; }
  
}
