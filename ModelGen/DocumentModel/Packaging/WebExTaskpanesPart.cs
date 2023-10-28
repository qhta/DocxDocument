namespace DocumentModel.Packaging;


/// <summary>
///   Defines the WebExTaskpanesPart
/// </summary>
public partial class WebExTaskpanesPart
{
  public String? ContentType { get; set; }
  
  public String? RelationshipType { get; set; }
  
  
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public DMWEP.Taskpanes? Taskpanes { get; set; }
  
}
