namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the SourceConnection Class.
/// </summary>
public interface ISourceConnection // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// name, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? Name { get ; set; }
  
}
