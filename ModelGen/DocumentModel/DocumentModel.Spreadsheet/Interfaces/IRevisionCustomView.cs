namespace DocumentModel.Spreadsheet;

/// <summary>
/// Revision Custom View.
/// </summary>
public interface IRevisionCustomView // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// GUID
  /// </summary>
  public string? Guid { get ; set; }
  
  /// <summary>
  /// User Action
  /// </summary>
  public RevisionActionValues? Action { get ; set; }
  
}
