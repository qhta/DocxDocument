namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the Extension Class.
/// </summary>
public class Extension: ModelElement
{
  /// <summary>
  ///   uri, this property is Ionly available Iin Office 2021 and later.
  /// </summary>
  public string? Uri { get; set; }
}
