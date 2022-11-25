namespace DocumentModel.Wordprocessing;

/// <summary>
/// Grid Column Definition.
/// </summary>
public interface IGridColumn // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Grid Column Width
  /// </summary>
  public System.String? Width { get ; set; }
  
}
