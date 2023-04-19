namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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