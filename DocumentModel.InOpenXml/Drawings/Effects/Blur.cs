namespace DocumentModel.Drawings;
/// <summary>
/// Represents a blur effect, allowing the application of a blur with a specified radius and optional bounds growth.
/// </summary>
[OpenXmlType(typeof(DXD.Blur))]
public partial class Blur : ModelElement<DXD.Blur>
{
 /// <summary>
 /// Radius of the blur effect.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.Blur.Radius))]
 /// <summary>
 /// Radius of the blur effect.
 /// </summary>
 [OpenXmlElement(typeof(DXD.Blur))]
 public Int64? Radius { get => _Radius; set => UpdateField(ref _Radius, value, nameof(Radius)); }

 private Int64? _Radius;
 /// <summary>
 /// Gets or sets a value indicating whether the bounds should grow to accommodate the blur.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.Blur.Grow))]
 /// <summary>
 /// Gets or sets a value indicating whether the bounds should grow to accommodate the blur.
 /// </summary>
 [OpenXmlElement(typeof(DXD.Blur))]
 public bool? Grow { get => _Grow; set => UpdateField(ref _Grow, value, nameof(Grow)); }

 private bool? _Grow;
}