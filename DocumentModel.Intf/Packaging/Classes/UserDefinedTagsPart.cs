namespace DocumentModel.Packaging;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the UserDefinedTagsPart
/// </summary>
public class UserDefinedTagsPart: ModelElement
{
  public string? ContentType { get; set; }

  public string? RelationshipType { get; set; }
}