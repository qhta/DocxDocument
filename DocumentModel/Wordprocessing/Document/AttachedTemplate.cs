namespace DocumentModel.Wordprocessing;

/// <summary>
///   Relationship for attached document template.
/// </summary>
public class AttachedTemplate: ExternalFile
{
  /// <summary>
  /// Modified for tests.
  /// </summary>
  /// <returns></returns>
  public override string ToString()
  {
    return $"Id={Id} Uri={Uri}";
  }
}