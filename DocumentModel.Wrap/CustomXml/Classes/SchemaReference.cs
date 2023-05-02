namespace DocumentModel.CustomXml;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Associated XML Schema.
/// </summary>
public class SchemaReference: ModelElement
{
  /// <summary>
  ///   Target Namespace of Associated XML Schema
  /// </summary>
  public string? Uri { get; set; }
}