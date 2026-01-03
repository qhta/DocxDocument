namespace DocumentModel.Drawings;

/// <summary>
///   Defines the CreationId interface.
/// </summary>
public interface CreationId: IModelElement
{
  /// <summary>
  ///   id
  /// </summary>
  public string? Id { get; set; }
}