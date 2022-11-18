namespace DocumentModel.Wordprocessing;

/// <summary>
/// Grid Column Definition.
/// </summary>
public interface IGridColumn // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Grid Column Width
  /// </summary>
  public string? Width { get ; set; }
  
}
