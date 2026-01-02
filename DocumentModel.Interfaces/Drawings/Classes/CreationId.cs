namespace DocumentModel.Drawings;

/// <summary>
///   Defines the CreationId Class.
/// </summary>
public class CreationId: ModelElement
{
  /// <summary>
  ///   id, this property is only available in Office 2016 and later.
  /// </summary>
  public string? Id { get; set; }
}