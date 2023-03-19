namespace DocumentModel.CustomXml;

/// <summary>
///   Associated XML Schema.
/// </summary>
public class SchemaReference: ModelElement
{
  /// <summary>
  ///   Target Namespace of Associated XML Schema
  /// </summary>
  public String? Uri { get; set; }
}