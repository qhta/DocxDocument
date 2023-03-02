namespace DocumentModel.Drawings;

/// <summary>
///   Defines the LineEndPropertiesType Class.
/// </summary>
public record LineEndPropertiesType
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