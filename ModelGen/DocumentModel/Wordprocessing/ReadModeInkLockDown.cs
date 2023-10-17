namespace DocumentModel.Wordprocessing;


/// <summary>
///   Freeze Document Layout.
/// </summary>
public partial class ReadModeInkLockDown
{
  
  /// <summary>
  ///   Use Actual Pages, Not Virtual Pages
  /// </summary>
  public Boolean? UseActualPages { get; set; }
  
  
  /// <summary>
  ///   Virtual Page Width
  /// </summary>
  public UInt32? Width { get; set; }
  
  
  /// <summary>
  ///   Virtual Page Height
  /// </summary>
  public UInt32? Height { get; set; }
  
  
  /// <summary>
  ///   Font Size Scaling
  /// </summary>
  public String? FontSize { get; set; }
  
}
