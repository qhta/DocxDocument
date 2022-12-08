namespace DocumentModel.Drawings;

/// <summary>
/// Defines the DataLabelFieldTableEntry Class.
/// </summary>
public class DataLabelFieldTableEntryImpl: ModelElementImpl, DataLabelFieldTableEntry
{
  public DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTableEntry? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelFieldTableEntry?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// TextFieldGuid.
  /// </summary>
  public String? TextFieldGuid
  {
    get;
    set;
  }
  
  /// <summary>
  /// Formula.
  /// </summary>
  public String? Formula
  {
    get;
    set;
  }
  
  /// <summary>
  /// DataLabelFieldTableCache.
  /// </summary>
  public DataLabelFieldTableCache? DataLabelFieldTableCache
  {
    get;
    set;
  }
  
}
