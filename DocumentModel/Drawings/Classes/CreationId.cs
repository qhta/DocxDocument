namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the CreationId Class.
/// </summary>
public class CreationId: ModelElement
{
  /// <summary>
  ///   id, this property is only available in Office 2016 and later.
  /// </summary>
  public String? Id { get; set; }
}