namespace DocumentModel.Wordprocessing;


/// <summary>
///   Entry Categorization.
/// </summary>
public partial class Category
{
  
  /// <summary>
  ///   Category Associated With Entry.
  /// </summary>
  public DMW.Name? Name { get; set; }
  
  
  /// <summary>
  ///   Gallery Associated With Entry.
  /// </summary>
  public DMW.DocPartGalleryKind? Gallery { get; set; }
  
}
