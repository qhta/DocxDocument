namespace DocumentModel.Vml;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   IShape Clipping Path.
/// </summary>
public class ClipPath: ModelElement
{
  /// <summary>
  ///   Path Definition
  /// </summary>
  public string? Value { get; set; }
}
