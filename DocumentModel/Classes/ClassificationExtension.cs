namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the ClassificationExtension Class.
/// </summary>
public class ClassificationExtension: ModelElement
{
  /// <summary>
  ///   uri, this property is only available in Office 2021 and later.
  /// </summary>
  public string? Uri { get; set; }
}