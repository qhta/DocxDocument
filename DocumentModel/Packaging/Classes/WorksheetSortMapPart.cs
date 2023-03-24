namespace DocumentModel.Packaging;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the WorksheetSortMapPart
/// </summary>
public class WorksheetSortMapPart: ModelElement
{
  public String? ContentType { get; set; }

  public String? RelationshipType { get; set; }
}