using DocumentModel.Wordprocessing;

namespace DocumentModel.Packaging;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the VbaDataPart
/// </summary>
public class VbaDataPart: ModelElement
{
  public String? ContentType { get; set; }

  public String? RelationshipType { get; set; }

  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public VbaSuppData? VbaSuppData { get; set; }
}