namespace DocumentModel.Wordprocessing;

/// <summary>
///   Custom XSL Transform To Use When Saving As XML File.
/// </summary>
public record SaveThroughXslt
{
  /// <summary>
  ///   XSL Transformation Location
  /// </summary>
  public String? Id { get; set; }

  /// <summary>
  ///   Local Identifier for XSL Transform
  /// </summary>
  public String? SolutionId { get; set; }
}