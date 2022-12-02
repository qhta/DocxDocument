namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the SetLevel Class.
/// </summary>
public interface ISetLevel // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// hierarchy, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Hierarchy { get ; set; }
  
}
