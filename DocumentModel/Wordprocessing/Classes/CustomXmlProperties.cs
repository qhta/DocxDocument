namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Custom XML Element Properties.
/// </summary>
public class CustomXmlProperties: ModelElement
{
  /// <summary>
  ///   Custom XML Element Placeholder Text.
  /// </summary>
  public String? CustomXmlPlaceholder { get; set; }

  public Collection<CustomXmlAttribute>? CustomXmlAttributes { get; set; }
}