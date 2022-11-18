namespace DocumentModel.Spreadsheet;

/// <summary>
/// External Reference.
/// </summary>
public interface IExternalReference // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Relationship Id
  /// </summary>
  public string? Id { get ; set; }
  
}
