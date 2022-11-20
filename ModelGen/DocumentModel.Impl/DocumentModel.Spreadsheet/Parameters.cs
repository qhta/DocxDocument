namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the Parameters Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IParameter))]
public class Parameters: IParameters
{
  /// <summary>
  /// Parameter Count
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
}
