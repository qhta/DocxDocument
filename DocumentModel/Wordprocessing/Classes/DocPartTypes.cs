namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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