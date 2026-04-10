namespace DocumentModel.Drawings;
/// <summary>
///   Represents a preset geometry for a shape, including the preset type and optional adjustment values.
/// </summary>
[OpenXmlType(typeof(DXD.PresetGeometry))]
[XmlRoot("PresetGeometry", Namespace = "DocumentModel.Drawings")]
public partial class PresetGeometry : ModelElement<DXD.PresetGeometry>
{
 /// <summary>
 ///   Preset shape type.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.PresetGeometry.Preset))]
 public BuiltInShapeType? Preset { get => _Preset; set => UpdateField(ref _Preset, value, nameof(Preset)); }

 private BuiltInShapeType? _Preset;
 /// <summary>
 ///   List of adjustment values for the preset shape.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.PresetGeometry.AdjustValueList))]
 public AdjustValueList? AdjustValueList { get => _AdjustValueList; set => UpdateField(ref _AdjustValueList, value, nameof(AdjustValueList)); }

 private AdjustValueList? _AdjustValueList;
}