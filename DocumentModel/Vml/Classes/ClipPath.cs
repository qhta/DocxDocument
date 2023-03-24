namespace DocumentModel.Vml;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Shape Clipping Path.
/// </summary>
public class ClipPath: ModelElement
{
  /// <summary>
  ///   Path Definition
  /// </summary>
  public String? Value { get; set; }
}