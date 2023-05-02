namespace DocumentModel.Wordprocessing;

/// <summary>
///   Custom XSL Transform To Use When Saving As XML File.
/// </summary>
public class SaveThroughXslt: ModelElement
{
  /// <summary>
  ///   XSL Transformation Location
  /// </summary>
  public string? Id { get; set; }

  /// <summary>
  ///   Local Identifier for XSL Transform
  /// </summary>
  public string? SolutionId { get; set; }
}