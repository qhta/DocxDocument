namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the LineEndPropertiesType Class.
/// </summary>
public class LineEndPropertiesType: ModelElement
{
  /// <summary>
  ///   Line Head/End Type
  /// </summary>
  public LineEndKind? Type { get; set; }

  /// <summary>
  ///   Width of Head/End
  /// </summary>
  public LineEndWidthKind? Width { get; set; }

  /// <summary>
  ///   Length of Head/End
  /// </summary>
  public LineEndLengthKind? Length { get; set; }
}