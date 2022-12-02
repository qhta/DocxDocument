namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the SlicerRef Class.
/// </summary>
public interface ISlicerRef // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? Id { get ; set; }
  
}
