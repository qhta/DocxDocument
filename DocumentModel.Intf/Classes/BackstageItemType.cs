namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the BackstageItemType Class.
/// </summary>
public class BackstageItemType: ModelElement
{
  /// <summary>
  ///   id, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Id { get; set; }

  /// <summary>
  ///   label, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Label { get; set; }

  /// <summary>
  ///   getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetLabel { get; set; }
}