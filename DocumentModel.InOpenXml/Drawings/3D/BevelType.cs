namespace DocumentModel.Drawings;
/// <summary>
/// Represents a bevel effect, defining the width, height, and preset style for 3D effects on shapes.
/// </summary>
[OpenXmlType(typeof(DXD.BevelType))]
public partial class BevelType : ModelElement<DXD.BevelType>
{
 /// <summary>
 /// Width of the bevel.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.BevelType.Width))]
 public Int64? Width { get => _Width; set => UpdateField(ref _Width, value, nameof(Width)); }

 private Int64? _Width;
 /// <summary>
 /// Height of the bevel.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.BevelType.Height))]
 public Int64? Height { get => _Height; set => UpdateField(ref _Height, value, nameof(Height)); }

 private Int64? _Height;
 /// <summary>
 /// Preset bevel style.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.BevelType.Preset))]
 public BevelPresets? Preset { get => _Preset; set => UpdateField(ref _Preset, value, nameof(Preset)); }

 private BevelPresets? _Preset;
}