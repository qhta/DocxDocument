namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ScatterSerExtension Class.
/// </summary>
public class ScatterSerExtensionImpl: ModelElementImpl, ScatterSerExtension
{
  public DocumentFormat.OpenXml.Drawing.Charts.ScatterSerExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.ScatterSerExtension?)_OpenXmlElement;
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
