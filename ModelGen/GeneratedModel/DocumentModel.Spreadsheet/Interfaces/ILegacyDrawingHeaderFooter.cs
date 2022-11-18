namespace DocumentModel.Spreadsheet;

/// <summary>
/// Legacy Drawing Reference in  Header Footer.
/// </summary>
public interface ILegacyDrawingHeaderFooter // : DocumentFormat.OpenXml.Spreadsheet.LegacyDrawingType
{
  /// <summary>
  /// Relationship Id
  /// </summary>
  public string? Id { get ; set; }
  
}
