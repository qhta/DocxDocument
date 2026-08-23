namespace DocumentModel;

/// <summary>
/// Represents a color model element with a generic underlying Open XML element type.
/// </summary>
/// <typeparam name = "T">The type of the underlying Open XML element represented by this color model element. Must derive from
/// DX.OpenXmlElement.</typeparam>
[XmlInclude(typeof(DMW.WordColor))]
[XmlInclude(typeof(DMD.RgbColorModelHex))]
[XmlInclude(typeof(DMD.SchemeColor))]
[XmlInclude(typeof(DMD.RgbColorModelPercentage))]
[XmlInclude(typeof(DMD.PresetColor))]
[XmlInclude(typeof(DMD.SystemColor))]
[XmlInclude(typeof(DMD.HslColor))]
[XmlInclude(typeof(DMW.RgbColorHex))]
[XmlInclude(typeof(DMW.SchemeColor))]
[JsonPolymorphic(TypeDiscriminatorPropertyName = "$type")]
[JsonDerivedType(typeof(DMW.WordColor), "DocumentModel.Wordprocessing.Color")]
[JsonDerivedType(typeof(DMD.RgbColorModelHex), "DocumentModel.Drawings.RgbColorModelHex")]
[JsonDerivedType(typeof(DMD.SchemeColor), "DocumentModel.Drawings.SchemeColor")]
[JsonDerivedType(typeof(DMD.RgbColorModelPercentage), "DocumentModel.Drawings.RgbColorModelPercentage")]
[JsonDerivedType(typeof(DMD.PresetColor), "DocumentModel.Drawings.PresetColor")]
[JsonDerivedType(typeof(DMD.SystemColor), "DocumentModel.Drawings.SystemColor")]
[JsonDerivedType(typeof(DMD.HslColor), "DocumentModel.Drawings.HslColor")]
[JsonDerivedType(typeof(DMW.RgbColorHex), "DocumentModel.Wordprocessing.RgbColorModelHex")]
[JsonDerivedType(typeof(DMW.SchemeColor), "DocumentModel.Wordprocessing.SchemeColor")]

public abstract class AnyColor<T> : ModelElement<T> where T : DX.OpenXmlElement
{

}