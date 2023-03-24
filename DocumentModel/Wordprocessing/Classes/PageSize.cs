namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the PageSize Class.
/// </summary>
public class PageSize: ModelElement, ISectionPropertiesElement
{
  /// <summary>
  ///   Page Width
  /// </summary>
  public DXA? Width { get; set; }

  /// <summary>
  ///   Page Height
  /// </summary>
  public DXA? Height { get; set; }

  /// <summary>
  ///   Page Orientation
  /// </summary>
  public PageOrientationKind? Orient { get; set; }

  /// <summary>
  ///   Printer Paper Code
  /// </summary>
  public UInt16? Code { get; set; }

  /// <summary>
  ///   Printer Paper Code
  /// </summary>
  public PaperSize? PaperSize 
    { get => (PaperSize?)Code;
      set => Code = (UInt16?)value; 
    }

}