namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the VerticalMerge Class.
/// </summary>
public interface IVerticalMerge // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Vertical Merge Type
  /// </summary>
  public MergedCell? Val { get ; set; }
  
}
