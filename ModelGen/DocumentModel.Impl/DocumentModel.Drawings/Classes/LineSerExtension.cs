namespace DocumentModel.Drawings;

/// <summary>
/// Defines the LineSerExtension Class.
/// </summary>
public class LineSerExtensionImpl: ModelElementImpl, LineSerExtension
{
  public DocumentFormat.OpenXml.Drawing.Charts.LineSerExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.LineSerExtension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri
  {
    get;
    set;
  }
  
  public FilteredSeriesTitle? FilteredSeriesTitle
  {
    get;
    set;
  }
  
  public FilteredCategoryTitle? FilteredCategoryTitle
  {
    get;
    set;
  }
  
  public DataLabelsRange? DataLabelsRange
  {
    get;
    set;
  }
  
  public CategoryFilterExceptions? CategoryFilterExceptions
  {
    get;
    set;
  }
  
}
