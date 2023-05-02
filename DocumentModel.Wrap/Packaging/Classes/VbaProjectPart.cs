namespace DocumentModel.Packaging;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the VbaProjectPart
/// </summary>
public class VbaProjectPart: ModelElement
{
  public string? ContentType { get; set; }

  public string? RelationshipType { get; set; }
}