namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the Extension Class.
/// </summary>
public class Extension: ModelElement
{
  /// <summary>
  ///   uri, this property is only available in Office 2021 and later.
  /// </summary>
  public String? Uri { get; set; }
}