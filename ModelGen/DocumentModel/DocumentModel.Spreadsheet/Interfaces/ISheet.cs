namespace DocumentModel.Spreadsheet;

/// <summary>
/// Sheet Information.
/// </summary>
public interface ISheet // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Sheet Name
  /// </summary>
  public string? Name { get ; set; }
  
  /// <summary>
  /// Sheet Tab Id
  /// </summary>
  public uint? SheetId { get ; set; }
  
  /// <summary>
  /// Visible State
  /// </summary>
  public SheetStateValues? State { get ; set; }
  
  /// <summary>
  /// Relationship Id
  /// </summary>
  public string? Id { get ; set; }
  
}
