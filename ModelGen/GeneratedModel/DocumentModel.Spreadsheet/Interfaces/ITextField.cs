namespace DocumentModel.Spreadsheet;

/// <summary>
/// Text Import Field Settings.
/// </summary>
public interface ITextField // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Field Type
  /// </summary>
  public ExternalConnection? Type { get ; set; }
  
  /// <summary>
  /// Position
  /// </summary>
  public uint? Position { get ; set; }
  
}
