namespace DocumentModel.Drawings;

/// <summary>
///   Defines the CreationId interface.
/// </summary>
public interface CreationId: IModelElement
{
  /// <summary>
  ///   id, this property is only available in Office 2016 and later.
  /// </summary>
  public string? Id { get; set; }
}