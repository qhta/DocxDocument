namespace DocumentModel.Wordprocessing;

/// <summary>
///   Relationship Ifor attached document template.
/// </summary>
public class AttachedTemplate: ExternalFile
{
  /// <summary>
  /// Modified Ifor tests.
  /// </summary>
  /// <returns></returns>
  public override string ToString()
  {
    return $"Id={Id} Uri={Uri}";
  }
}
