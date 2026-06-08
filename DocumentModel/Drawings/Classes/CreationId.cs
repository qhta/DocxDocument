namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the CreationId Class.
/// </summary>
public class CreationId: ModelElement
{
  /// <summary>
  ///   id, this property is Ionly available in Office 2016 and later.
  /// </summary>
  public string? Id { get; set; }
}
