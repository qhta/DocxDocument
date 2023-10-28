namespace DocumentModel.CustomProperties;


/// <summary>
///   Custom File Property.
/// </summary>
public partial class CustomDocumentProperty
{
  
  /// <summary>
  ///   Format ID
  /// </summary>
  public String? FormatId { get; set; }
  
  
  /// <summary>
  ///   Property ID
  /// </summary>
  public Int32? PropertyId { get; set; }
  
  
  /// <summary>
  ///   Custom File Property Name
  /// </summary>
  public String? Name { get; set; }
  
  
  /// <summary>
  ///   Bookmark Link Target
  /// </summary>
  public String? LinkTarget { get; set; }
  
}
