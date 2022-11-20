namespace DocumentModel.Spreadsheet;

/// <summary>
/// Metadata Record.
/// </summary>
public class MetadataRecord: IMetadataRecord
{
  /// <summary>
  /// Metadata Record Type Index
  /// </summary>
  public uint? TypeIndex
  {
    get;
    set;
  }
  
  /// <summary>
  /// Metadata Record Value Index
  /// </summary>
  public uint? Val
  {
    get;
    set;
  }
  
}
