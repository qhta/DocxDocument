namespace DocumentModel.CustomXml;

/// <summary>
///   Associated XML Schema.
/// </summary>
public record SchemaReference
{
  /// <summary>
  ///   Target Namespace of Associated XML Schema
  /// </summary>
  public String? Uri { get; set; }
}