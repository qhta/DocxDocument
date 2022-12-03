namespace DocumentModel.Spreadsheet;

/// <summary>
/// Cell Properties.
/// </summary>
public interface XmlCellProperties // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Table Field Id
  /// </summary>
  public UInt32? Id { get ; set; }
  
  /// <summary>
  /// Unique Table Name
  /// </summary>
  public String? UniqueName { get ; set; }
  
  /// <summary>
  /// Column XML Properties.
  /// </summary>
  public XmlProperties? XmlProperties { get ; set; }
  
  /// <summary>
  /// Future Feature Data Storage Area.
  /// </summary>
  public ExtensionList? ExtensionList { get ; set; }
  
}
