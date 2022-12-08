namespace DocumentModel.Wordprocessing;

/// <summary>
/// Vertically Merged/Split Table Cells.
/// </summary>
public class CellMergeImpl: ModelElementImpl, CellMerge
{
  public DocumentFormat.OpenXml.Wordprocessing.CellMerge? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.CellMerge?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
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
  
  /// <summary>
  /// author
  /// </summary>
  public String? Author
  {
    get;
    set;
  }
  
  /// <summary>
  /// date
  /// </summary>
  public DateTime? Date
  {
    get;
    set;
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public String? Id
  {
    get;
    set;
  }
  
}
