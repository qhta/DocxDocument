namespace DocumentModel.Wordprocessing;

/// <summary>
/// Vertically Merged/Split Table Cells.
/// </summary>
public class CellMergeImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.CellMerge>, CellMerge
{
  /// <summary>
  /// vMerge
  /// </summary>
  public VerticalMergeRevisionKind? VerticalMerge
  {
    get => (VerticalMergeRevisionKind?)OpenXmlElement?.VerticalMerge?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.VerticalMerge = (DocumentFormat.OpenXml.Wordprocessing.VerticalMergeRevisionValues?)value;
    }
  }
  
  /// <summary>
  /// vMergeOrig
  /// </summary>
  public VerticalMergeRevisionKind? VerticalMergeOriginal
  {
    get => (VerticalMergeRevisionKind?)OpenXmlElement?.VerticalMergeOriginal?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.VerticalMergeOriginal = (DocumentFormat.OpenXml.Wordprocessing.VerticalMergeRevisionValues?)value;
    }
  }
  
}
