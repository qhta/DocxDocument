namespace DocumentModel.Drawings;

/// <summary>
///   Represents properties for the line end, including type, width, and length of the line head or end.
/// </summary>
public interface LineEndPropertiesType
{
  /// <summary>
  ///   Type of the line head or end.
  /// </summary>
  public LineEndKind? Type { get; set; }

  /// <summary>
  ///   Width of the line head or end.
  /// </summary>
  public LineEndWidthKind? Width { get; set; }

  /// <summary>
  ///   Length of the line head or end.
  /// </summary>
  public LineEndLengthKind? Length { get; set; }
}