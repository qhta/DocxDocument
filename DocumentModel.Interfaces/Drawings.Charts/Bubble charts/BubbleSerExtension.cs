namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the BubbleSerExtension Class.
/// </summary>
public interface BubbleSerExtension: Extension
{
  public InvertSolidFillFormat? InvertSolidFillFormat { get; set; }
  public FilteredCategoryTitle? FilteredCategoryTitle { get; set; }
  public DataLabelsRange? DataLabelsRange { get; set; }
  public CategoryFilterExceptions? CategoryFilterExceptions { get; set; }
}