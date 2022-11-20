namespace DocumentModel.Wordprocessing;

/// <summary>
/// Freeze Document Layout.
/// </summary>
public class ReadModeInkLockDown: IReadModeInkLockDown
{
  /// <summary>
  /// Use Actual Pages, Not Virtual Pages
  /// </summary>
  public bool? UseActualPages
  {
    get;
    set;
  }
  
  /// <summary>
  /// Virtual Page Width
  /// </summary>
  public uint? Width
  {
    get;
    set;
  }
  
  /// <summary>
  /// Virtual Page Height
  /// </summary>
  public uint? Height
  {
    get;
    set;
  }
  
  /// <summary>
  /// Font Size Scaling
  /// </summary>
  public string? FontSize
  {
    get;
    set;
  }
  
}
