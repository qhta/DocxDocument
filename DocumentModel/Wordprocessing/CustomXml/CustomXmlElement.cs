namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines CustomXmlElement - the base class for the customXml elements.
/// </summary>
public class CustomXmlElement: ModelElement
{
  /// <summary>
  ///   Gets or sets the custom XML Markup Namespace.
  /// </summary>
  public string? Uri { get; set; }

  /// <summary>
  ///   Gets or sets the element name.
  /// </summary>
  public string? Element { get; set; }

  /// <summary>
  ///   Gets or sets the CustomXmlProperties which represents the element tag in schema: w:customXmlPr.
  /// </summary>
  public CustomXmlProperties? CustomXmlProperties { get; set; }
}