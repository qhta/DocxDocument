namespace DocumentModel.Spreadsheet;

/// <summary>
/// Revision AutoFormat.
/// </summary>
public class RevisionAutoFormat: IRevisionAutoFormat
{
  /// <summary>
  /// Sheet Id
  /// </summary>
  public uint? SheetId
  {
    get;
    set;
  }
  
  /// <summary>
  /// Auto Format Id
  /// </summary>
  public uint? AutoFormatId
  {
    get;
    set;
  }
  
  /// <summary>
  /// Apply Number Formats
  /// </summary>
  public bool? ApplyNumberFormats
  {
    get;
    set;
  }
  
  /// <summary>
  /// Apply Border Formats
  /// </summary>
  public bool? ApplyBorderFormats
  {
    get;
    set;
  }
  
  /// <summary>
  /// Apply Font Formats
  /// </summary>
  public bool? ApplyFontFormats
  {
    get;
    set;
  }
  
  /// <summary>
  /// Apply Pattern Formats
  /// </summary>
  public bool? ApplyPatternFormats
  {
    get;
    set;
  }
  
  /// <summary>
  /// Apply Alignment Formats
  /// </summary>
  public bool? ApplyAlignmentFormats
  {
    get;
    set;
  }
  
  /// <summary>
  /// Apply Width / Height Formats
  /// </summary>
  public bool? ApplyWidthHeightFormats
  {
    get;
    set;
  }
  
  /// <summary>
  /// Reference
  /// </summary>
  public string? Reference
  {
    get;
    set;
  }
  
}
