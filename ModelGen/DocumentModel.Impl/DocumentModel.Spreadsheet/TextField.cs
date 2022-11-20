namespace DocumentModel.Spreadsheet;

/// <summary>
/// Text Import Field Settings.
/// </summary>
public class TextField: ITextField
{
  /// <summary>
  /// Field Type
  /// </summary>
  public ExternalConnectionValues? Type
  {
    get;
    set;
  }
  
  /// <summary>
  /// Position
  /// </summary>
  public uint? Position
  {
    get;
    set;
  }
  
}
