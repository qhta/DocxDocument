namespace DocumentModel.Drawings;
/// <summary>
///   Represents a preset text wrap, including the wrap shape and optional adjustment values.
/// </summary>
[OpenXmlType(typeof(DXD.PresetTextWarp))]
public partial class PresetTextWrap : ModelElement<DXD.PresetTextWarp>
{
 /// <summary>
 ///   Preset wrap shape for the text wrap.
 /// </summary>
 public TextShape? Preset { get => _Preset; set => UpdateField(ref _Preset, value, nameof(Preset)); }

 private TextShape? _Preset;
 /// <summary>
 ///   List of adjustment values for the preset text wrap.
 /// </summary>
 public AdjustValueList? AdjustValueList { get => _AdjustValueList; set => UpdateField(ref _AdjustValueList, value, nameof(AdjustValueList)); }

 private AdjustValueList? _AdjustValueList;
}