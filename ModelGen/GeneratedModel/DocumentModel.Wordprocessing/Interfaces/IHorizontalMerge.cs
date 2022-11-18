namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the HorizontalMerge Class.
/// </summary>
public interface IHorizontalMerge // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Horizontal Merge Type
  /// </summary>
  public MergedCell? Val { get ; set; }
  
}
