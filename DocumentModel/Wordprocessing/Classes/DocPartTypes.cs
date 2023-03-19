namespace DocumentModel.Wordprocessing;

/// <summary>
///   Entry Types.
/// </summary>
public class DocPartTypes: ModelElement
{
  /// <summary>
  ///   Entry Is Of All Types
  /// </summary>
  public Boolean? All { get; set; }

  public DocPartKind? DocPartType { get; set; }
}