using DocumentModel.CustomXml;

namespace DocumentModel.Wordprocessing;

/// <summary>
///   Additional schemas attached to document.
/// </summary>
public class AttachedSchemas: ElementCollection<Schema>
{
  /// <summary>
  /// Modified for tests.
  /// </summary>
  /// <returns></returns>
  public override string ToString()
  {
    return $"AttachedSchemas()";
  }
}