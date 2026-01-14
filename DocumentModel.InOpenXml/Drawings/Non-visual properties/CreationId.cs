namespace DocumentModel.Drawings;

/// <summary>
///   Represents a unique creation identifier for a drawing element.
/// </summary>
public interface CreationId
{
  /// <summary>
  ///   Unique identifier value.
  /// </summary>
  public string? Id { get; set; }
}