namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Graphic Object Data.
/// </summary>
public class GraphicData: ModelElement
{
  /// <summary>
  ///   Uniform Resource Identifier
  /// </summary>
  public string? Uri { get; set; }
}