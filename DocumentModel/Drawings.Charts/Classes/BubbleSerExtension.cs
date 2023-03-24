namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the BubbleSerExtension Class.
/// </summary>
public class BubbleSerExtension: ModelElement
{
  /// <summary>
  ///   URI
  /// </summary>
  public String? Uri { get; set; }

  public InvertSolidFillFormat? InvertSolidFillFormat { get; set; }

  public FilteredCategoryTitle? FilteredCategoryTitle { get; set; }

  public DataLabelsRange? DataLabelsRange { get; set; }

  public CategoryFilterExceptions? CategoryFilterExceptions { get; set; }
}