namespace DocumentModel.Spreadsheet;

/// <summary>
/// Server Formats.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IServerFormat))]
public class ServerFormats: IServerFormats
{
  /// <summary>
  /// Format Count
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
}
