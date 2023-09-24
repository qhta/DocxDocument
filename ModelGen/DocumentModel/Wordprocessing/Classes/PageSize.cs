namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the PageSize Class.
/// </summary>
public partial class PageSize
{
  
  /// <summary>
  ///   Page Width
  /// </summary>
  public UInt32? Width { get; set; }
  
  
  /// <summary>
  ///   Page Height
  /// </summary>
  public UInt32? Height { get; set; }
  
  
  /// <summary>
  ///   Page Orientation
  /// </summary>
  public PageOrientationKind? Orient { get; set; }
  
  
  /// <summary>
  ///   Printer Paper Code
  /// </summary>
  public UInt16? Code { get; set; }
  
}
