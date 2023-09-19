namespace DocumentModel.Wordprocessing;


/// <summary>
///   Custom XSL Transform To Use When Saving As XML File.
/// </summary>
public partial class SaveThroughXslt
{
  
  /// <summary>
  ///   XSL Transformation Location
  /// </summary>
  [SchemaAttr("r:id")]
  public String? Id { get; set; }
  
  
  /// <summary>
  ///   Local Identifier for XSL Transform
  /// </summary>
  [SchemaAttr("w:solutionID")]
  public String? SolutionId { get; set; }
  
}
