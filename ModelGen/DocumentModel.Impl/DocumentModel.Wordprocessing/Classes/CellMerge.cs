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
  
  public CellMergeImpl(): base() {}
  
  public CellMergeImpl(DocumentFormat.OpenXml.Wordprocessing.CellMerge openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// vMerge
  /// </summary>
  public DocumentModel.Wordprocessing.VerticalMergeRevisionKind? VerticalMerge
  {
    get => (DocumentModel.Wordprocessing.VerticalMergeRevisionKind?)OpenXmlElement?.VerticalMerge?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.VerticalMerge = (DocumentFormat.OpenXml.Wordprocessing.VerticalMergeRevisionValues?)value;
    }
  }
  
  /// <summary>
  /// vMergeOrig
  /// </summary>
  public DocumentModel.Wordprocessing.VerticalMergeRevisionKind? VerticalMergeOriginal
  {
    get => (DocumentModel.Wordprocessing.VerticalMergeRevisionKind?)OpenXmlElement?.VerticalMergeOriginal?.Value;
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
    get => (System.String?)OpenXmlElement?.Author?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Author = (System.String?)value;
    }
  }
  
  /// <summary>
  /// date
  /// </summary>
  public DateTime? Date
  {
    get => (System.DateTime?)OpenXmlElement?.Date?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Date = (System.DateTime?)value;
    }
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public String? Id
  {
    get => (System.String?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.String?)value;
    }
  }
  
}
