namespace DocumentModel.Packaging;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the TimeLinePart
/// </summary>
public class TimeLinePart: ModelElement
{
  public String? ContentType { get; set; }

  public String? RelationshipType { get; set; }
}