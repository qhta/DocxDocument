namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the magnification setting for a Wordprocessing document.
/// This class provides properties for specifying the zoom type and zoom percentage, enabling control over the document's display magnification.
/// </summary>
[JsonConverter(typeof(ZoomJsonConverter))]
[OpenXmlType(typeof(DXW.Zoom))]
public partial class Zoom : ModelElement<DXW.Zoom>, IEquatable<Zoom>
{
 /// <summary>
 /// Zoom type, specifying the preset magnification mode.
 /// </summary>
 [OpenXmlProperty("Val")]
 public PresetZoom? Kind { get => _Kind; set => UpdateField(ref _Kind, value, nameof(Kind)); }

 private PresetZoom? _Kind;
 /// <summary>
 /// Zoom percentage, specifying the magnification level as a percentage.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.Zoom.Percent))]
 public int? Percent { get => _Percent; set => UpdateField(ref _Percent, value, nameof(Percent)); }

 private int? _Percent;
 /// <summary>
 /// Converts an integer percentage value to a Zoom instance.
 /// </summary>
 /// <remarks>This operator enables implicit conversion from an integer representing a zoom percentage to a
 /// Zoom object. This allows assignment of an integer directly to a Zoom variable without explicit casting.</remarks>
 /// <param name = "percent">The zoom level as a percentage. Must be a non-negative integer.</param>
 public static implicit operator Zoom(int percent)
 {
  return new Zoom
  {
   Percent = percent
  };
 }

 /// <summary>
 /// Returns a string representation of the Zoom instance, prioritizing the Type property if set, otherwise the Percent property.
 /// </summary>
 /// <returns></returns>
 public override string? ToString()
 {
  return Kind?.ToString() ?? Percent?.ToString() ?? base.ToString();
 }

 /// <summary>
 /// Implements equality comparison between two Zoom instances.
 /// </summary>
 /// <param name = "other">Other Zoom instance to compare with.</param>
 /// <remarks>Compares the Type and Percent properties for equality.</remarks>
 /// <returns>True if the two Zoom instances are equal; otherwise, false.</returns>
 public bool Equals(Zoom? other)
 {
  if (other is null)
   return false;
  if (ReferenceEquals(this, other))
   return true;
  return base.Equals(other) && Kind == other.Kind && Percent == other.Percent;
 }
}