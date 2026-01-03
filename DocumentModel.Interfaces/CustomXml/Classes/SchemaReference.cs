namespace DocumentModel.CustomXml;

/// <summary>
///   Associated XML Schema.
/// </summary>
public interface SchemaReference: IModelElement
{
  /// <summary>
  ///   Target Namespace of Associated XML Schema
  /// </summary>
  public string? Uri { get; set; }
}