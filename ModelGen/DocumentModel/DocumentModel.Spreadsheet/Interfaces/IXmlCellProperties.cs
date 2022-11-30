namespace DocumentModel.Spreadsheet;

/// <summary>
/// Cell Properties.
/// </summary>
public interface IXmlCellProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Table Field Id
  /// </summary>
  public System.UInt32? Id { get ; set; }
  
  /// <summary>
  /// Unique Table Name
  /// </summary>
  public System.String? UniqueName { get ; set; }
  
  /// <summary>
  /// Column XML Properties.
  /// </summary>
  public DocumentModel.Spreadsheet.IXmlProperties? XmlProperties { get ; set; }
  
  /// <summary>
  /// Future Feature Data Storage Area.
  /// </summary>
  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList { get ; set; }
  
}
