namespace DocumentModel.Math;
/// <summary>
///   This element specifies the properties of the Border Box object, which dictate the types of lines that can be drawn as part of the border. 
/// </summary>
[OpenXmlType(typeof(DXM.BorderBoxProperties))]
public partial class BorderBoxProperties : ModelElement<DXM.BorderBoxProperties>
{
 /// <summary>
 ///   Hide Top Edge.
 /// </summary>
 [OpenXmlProperty(nameof(DXM.BorderBoxProperties.HideTop))]
 [OpenXmlElement(typeof(DXM.BorderBoxProperties))]
 public bool? HideTop { get => _HideTop; set => UpdateField(ref _HideTop, value, nameof(HideTop)); }

 private bool? _HideTop;
 /// <summary>
 ///   Hide Bottom Edge.
 /// </summary>
 [OpenXmlProperty(nameof(DXM.BorderBoxProperties.HideBottom))]
 [OpenXmlElement(typeof(DXM.BorderBoxProperties))]
 public bool? HideBottom { get => _HideBottom; set => UpdateField(ref _HideBottom, value, nameof(HideBottom)); }

 private bool? _HideBottom;
 /// <summary>
 ///   Hide Left Edge.
 /// </summary>
 [OpenXmlProperty(nameof(DXM.BorderBoxProperties.HideLeft))]
 [OpenXmlElement(typeof(DXM.BorderBoxProperties))]
 public bool? HideLeft { get => _HideLeft; set => UpdateField(ref _HideLeft, value, nameof(HideLeft)); }

 private bool? _HideLeft;
 /// <summary>
 ///   Hide Right Edge.
 /// </summary>
 [OpenXmlProperty(nameof(DXM.BorderBoxProperties.HideRight))]
 [OpenXmlElement(typeof(DXM.BorderBoxProperties))]
 public bool? HideRight { get => _HideRight; set => UpdateField(ref _HideRight, value, nameof(HideRight)); }

 private bool? _HideRight;
 /// <summary>
 ///   Border Box Strikethrough Horizontal.
 /// </summary>
 [OpenXmlProperty(nameof(DXM.BorderBoxProperties.StrikeHorizontal))]
 [OpenXmlElement(typeof(DXM.BorderBoxProperties))]
 public bool? StrikeHorizontal { get => _StrikeHorizontal; set => UpdateField(ref _StrikeHorizontal, value, nameof(StrikeHorizontal)); }

 private bool? _StrikeHorizontal;
 /// <summary>
 ///   Border Box Strikethrough Vertical.
 /// </summary>
 [OpenXmlProperty(nameof(DXM.BorderBoxProperties.StrikeVertical))]
 [OpenXmlElement(typeof(DXM.BorderBoxProperties))]
 public bool? StrikeVertical { get => _StrikeVertical; set => UpdateField(ref _StrikeVertical, value, nameof(StrikeVertical)); }

 private bool? _StrikeVertical;
 /// <summary>
 ///   Border Box Strikethrough Bottom-Left to Top-Right.
 /// </summary>
 [OpenXmlProperty(nameof(DXM.BorderBoxProperties.StrikeBottomLeftToTopRight))]
 [OpenXmlElement(typeof(DXM.BorderBoxProperties))]
 public bool? StrikeBottomLeftToTopRight { get => _StrikeBottomLeftToTopRight; set => UpdateField(ref _StrikeBottomLeftToTopRight, value, nameof(StrikeBottomLeftToTopRight)); }

 private bool? _StrikeBottomLeftToTopRight;
 /// <summary>
 ///   Border Box Strikethrough Top-Left to Bottom-Right.
 /// </summary>
 [OpenXmlProperty(nameof(DXM.BorderBoxProperties.StrikeTopLeftToBottomRight))]
 [OpenXmlElement(typeof(DXM.BorderBoxProperties))]
 public bool? StrikeTopLeftToBottomRight { get => _StrikeTopLeftToBottomRight; set => UpdateField(ref _StrikeTopLeftToBottomRight, value, nameof(StrikeTopLeftToBottomRight)); }

 private bool? _StrikeTopLeftToBottomRight;
 /// <summary>
 ///   Specifies formatting of border-box object argument.
 /// </summary>
 [OpenXmlProperty(nameof(DXM.BorderBoxProperties.ControlProperties))]
 [OpenXmlElement(typeof(DXM.BorderBoxProperties))]
 public ControlProperties? ControlProperties { get => _ControlProperties; set => UpdateField(ref _ControlProperties, value, nameof(ControlProperties)); }

 private ControlProperties? _ControlProperties;
}