namespace DocumentModel.Drawings;

/// <summary>
/// Defines the BarSerExtension Class.
/// </summary>
public class BarSerExtensionImpl: ModelElementImpl, BarSerExtension
{
  public DocumentFormat.OpenXml.Drawing.Charts.BarSerExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.BarSerExtension?)_OpenXmlElement;
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
  
  public InvertSolidFillFormat? InvertSolidFillFormat
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
