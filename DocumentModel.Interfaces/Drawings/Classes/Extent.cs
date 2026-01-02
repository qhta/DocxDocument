namespace DocumentModel.Drawings;
/// <summary>
///   Extent for 2D drawings
/// </summary>
[TypeConverter(typeof(ExtentTypeConverter))]
public record Extent
{
  /// <summary>
  ///   X extent
  /// </summary>
  public EMU Cx { get; set; }
  /// <summary>
  ///   Y extent
  /// </summary>
  public EMU Cy { get; set; }
}