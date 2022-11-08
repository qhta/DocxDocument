namespace DocxDocument.Model;

public struct ReadModeInkLockDown
{
  /// <summary> 
  /// Font Size Scaling.
  ///</summary>
  public Percentage? FontSize { get; set; }

  /// <summary> 
  /// Use Actual Pages, Not Virtual Pages.
  ///</summary> 
  public bool? UseActualPages { get; set; }

  /// <summary> 
  /// Virtual Page Width.
  ///</summary> 
  public Pixels? Width { get; set; }

  /// <summary> 
  /// Virtual Page Height.
  ///</summary> 
  public Pixels? Height { get; set; }


}