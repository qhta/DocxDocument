namespace DocumentModel.Drawings;
/// <summary>
///   Represents a hue, saturation, and luminance (HSL) effect for color adjustment.
/// </summary>
[OpenXmlType(typeof(DXD.Hsl))]
[DataContract]
[XmlRoot("Hsl", Namespace = "DocumentModel.Drawings")]
public partial class Hsl : ModelElement<DXD.Hsl>
{
  /// <summary>
  ///   Hue component of the color.
  /// </summary>
  public Int32? Hue { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  ///   Saturation component of the color.
  /// </summary>
  public Int32? Saturation { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  ///   Luminance component of the color.
  /// </summary>
  public Int32? Luminance { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}