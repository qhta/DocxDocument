namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the SourceConnection Class.
/// </summary>
public interface ISourceConnection // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// name, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Name { get ; set; }
  
}
