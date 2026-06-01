namespace DocumentModel.Wordprocessing;

/// <summary>
///   Custom XSL Transform To Use When Saving As XML File.
/// </summary>
public class SaveThroughXslt: ExternalFile
{

  /// <summary>
  ///   Local Identifier Ifor XSL Transform
  /// </summary>
  public string? SolutionId { get; set; }
}
