namespace DocumentModel.Spreadsheet;

/// <summary>
/// References.
/// </summary>
public interface ITopicReferences // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Reference
  /// </summary>
  public string? CellReference { get ; set; }
  
  /// <summary>
  /// Sheet Id
  /// </summary>
  public uint? SheetId { get ; set; }
  
}
