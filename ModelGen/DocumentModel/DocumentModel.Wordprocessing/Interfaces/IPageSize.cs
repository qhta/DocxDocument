namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the PageSize Class.
/// </summary>
public interface IPageSize // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Page Width
  /// </summary>
  public System.UInt32? Width { get ; set; }
  
  /// <summary>
  /// Page Height
  /// </summary>
  public System.UInt32? Height { get ; set; }
  
  /// <summary>
  /// Page Orientation
  /// </summary>
  public DocumentModel.Wordprocessing.PageOrientationKind? Orient { get ; set; }
  
  /// <summary>
  /// Printer Paper Code
  /// </summary>
  public System.UInt16? Code { get ; set; }
  
}
