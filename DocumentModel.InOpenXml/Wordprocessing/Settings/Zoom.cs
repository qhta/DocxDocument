namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the magnification setting for a Wordprocessing document.
/// This class provides properties for specifying the zoom type and zoom percentage, enabling control over the document's display magnification.
/// </summary>
[JsonConverter(typeof(ZoomJsonConverter))]
[OpenXmlType(typeof(DXW.Zoom))]
[XmlRoot("Zoom", Namespace = "DocumentModel.Wordprocessing")]
public partial class Zoom : ModelElement<DXW.Zoom>, IEquatable<Zoom>
{
 /// <summary>
 /// Zoom type, specifying the preset magnification mode.
 /// </summary>
 [OpenXmlProperty("Val")]
 public PresetZoom? Preset { get => _preset; set => UpdateField(ref _preset, value, nameof(Preset)); }

 private PresetZoom? _preset;
 /// <summary>
 /// Zoom percentage, specifying the magnification level as a percentage.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.Zoom.Percent))]
 public Percent? Percent { get => _Percent; set => UpdateField(ref _Percent, value, nameof(Percent)); }

 private Percent? _Percent;
 /// <summary>
 /// Converts an integer percentage value to a Zoom instance.
 /// </summary>
 /// <remarks>This operator enables implicit conversion from an integer representing a zoom percentage to a
 /// Zoom object. This allows assignment of an integer directly to a Zoom variable without explicit casting.</remarks>
 /// <param name = "value">The zoom level as a percentage. Must be a non-negative integer.</param>
 public static implicit operator Zoom(string value)
 {
  if (value.EndsWith("%"))
   return new Zoom
   {
    Percent = int.Parse(value.TrimEnd('%'))
   };
  else
   return new Zoom
   {
    Preset = (PresetZoom)Enum.Parse(typeof(PresetZoom), value)
   };
 }

 /// <summary>
 /// Checks if the Zoom instance represents a percentage zoom.
 /// </summary>
 /// <returns>True if the instance represents a percentage zoom; otherwise, false.</returns>
 public bool IsPercent() => Percent is not null;
 /// <summary>
 /// Checks if the Zoom instance represents a preset zoom.
 /// </summary>
 /// <returns>True if the instance represents a preset zoom; otherwise, false.</returns>
 public bool IsPreset() => Preset is not null;
 /// <summary>
 /// Implicitly converts a Zoom instance to its PresetZoom value.
 /// </summary>
 /// <param name = "zoom">Zoom instance to convert.</param>
 public static implicit operator PresetZoom(Zoom zoom) => zoom.Preset!.Value;
 /// <summary>
 /// Implicitly converts a PresetZoom value to a Zoom instance.
 /// </summary>
 /// <param name = "preset">PresetZoom value to convert.</param>
 public static implicit operator Zoom(PresetZoom preset) => new Zoom
 {
  Preset = preset
 };
 /// <summary>
 /// Implicitly converts a Zoom instance to its Percent value.
 /// </summary>
 /// <param name = "zoom">Zoom instance to convert.</param>
 public static implicit operator Percent(Zoom zoom) => zoom.Percent ?? default(Percent);
 /// <summary>
 /// Implicitly converts a Percent value to a Zoom instance.
 /// </summary>
 /// <param name = "percent">Percent value to convert.</param>
 public static implicit operator Zoom(Percent percent) => new Zoom
 {
  Percent = percent
 };
 /// <summary>
 /// Returns a string representation of the Zoom instance, prioritizing the Type property if set, otherwise the Percent property.
 /// </summary>
 /// <returns>String representation of the Zoom instance.</returns>
 public override string? ToString()
 {
  return Preset?.ToString() ?? Percent?.ToString() ?? base.ToString();
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
  return base.Equals(other) && Preset == other.Preset && Percent == other.Percent;
 }
}