namespace DocumentModel.Drawings;

/// <summary>
///   Represents a unique creation identifier for a drawing element.
/// </summary>
public class CreationId: ModelElement<DXO16D.CreationId>
{
  /// <summary>
  ///   Unique identifier value.
  /// </summary>
  public string? Id { get; set; }
}