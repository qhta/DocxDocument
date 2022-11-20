namespace DocumentModel.Spreadsheet;

/// <summary>
/// External Cell Data.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IXstring))]
public class ExternalCell: IExternalCell
{
  /// <summary>
  /// Reference
  /// </summary>
  public string? CellReference
  {
    get;
    set;
  }
  
  /// <summary>
  /// Type
  /// </summary>
  public CellValues? DataType
  {
    get;
    set;
  }
  
  /// <summary>
  /// Value Metadata
  /// </summary>
  public uint? ValueMetaIndex
  {
    get;
    set;
  }
  
  /// <summary>
  /// Value.
  /// </summary>
  public DocumentModel.Spreadsheet.IXstring? Xstring
  {
    get;
    set;
  }
  
}
