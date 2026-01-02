using DocumentModel.Wordprocessing;
namespace DocumentModel.Packaging;

/// <summary>
///   Defines the VbaDataPart
/// </summary>
public class VbaDataPart: ModelElement
{
  public string? ContentType { get; set; }
  public string? RelationshipType { get; set; }
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public VbaSuppData? VbaSuppData { get; set; }
}