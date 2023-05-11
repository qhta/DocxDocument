namespace DocumentModel.Wordprocessing;

/// <summary>
///   Custom XSL Transform To Use When Saving As XML File.
/// </summary>
public class SaveThroughXslt: ExternalFile
{

  /// <summary>
  ///   Local Identifier for XSL Transform
  /// </summary>
  public string? SolutionId { get; set; }
}