namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the SourceConnection Class.
/// </summary>
public interface ISourceConnection // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// name, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Name { get ; set; }
  
}
