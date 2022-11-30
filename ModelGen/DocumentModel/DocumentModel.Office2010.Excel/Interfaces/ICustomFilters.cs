namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the CustomFilters Class.
/// </summary>
public interface ICustomFilters // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// and, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Boolean? And { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Office2010.Excel.ICustomFilter>? CustomFilters { get ; set; }
  
}
