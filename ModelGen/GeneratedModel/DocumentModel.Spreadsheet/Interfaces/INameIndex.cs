namespace DocumentModel.Spreadsheet;

/// <summary>
/// Member Unique Name Index.
/// </summary>
public interface INameIndex // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Index Value
  /// </summary>
  public uint? Index { get ; set; }
  
  /// <summary>
  /// String is a Set
  /// </summary>
  public bool? IsASet { get ; set; }
  
}
