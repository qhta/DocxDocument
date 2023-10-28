namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the BubbleSerExtension Class.
/// </summary>
public partial class BubbleSerExtension
{
  
  /// <summary>
  ///   URI
  /// </summary>
  public String? Uri { get; set; }
  
  public DMDC10.InvertSolidFillFormat? InvertSolidFillFormat { get; set; }
  
  public DMDC13.FilteredCategoryTitle? FilteredCategoryTitle { get; set; }
  
  public DMDC13.DataLabelsRange? DataLabelsRange { get; set; }
  
  public DMDC13.CategoryFilterExceptions? CategoryFilterExceptions { get; set; }
  
}
