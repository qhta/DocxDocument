namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the DbTable Class.
/// </summary>
public interface IDbTable // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// name, this property is only available in Office 2013 and later.
  /// </summary>
  public string? Name { get ; set; }
  
}
