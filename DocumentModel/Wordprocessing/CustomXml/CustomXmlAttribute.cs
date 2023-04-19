namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Custom XML Attribute.
/// </summary>
public class CustomXmlAttribute: ModelElement
{
  /// <summary>
  ///   uri
  /// </summary>
  public string? Uri { get; set; }

  /// <summary>
  ///   name
  /// </summary>
  public string? Name { get; set; }

  /// <summary>
  ///   val
  /// </summary>
  public string? Val { get; set; }
}