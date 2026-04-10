using System.Runtime.Serialization;

namespace DocumentModel.Drawings;

/// <summary>
/// Represents a color model element with a generic underlying Open XML element type.
/// </summary>
/// <typeparam name = "T">The type of the underlying Open XML element represented by this color model element. Must derive from
/// DX.OpenXmlElement.</typeparam>
[XmlInclude(typeof(DMD.RgbColorModelHex))]
[XmlInclude(typeof(DMD.SchemeColor))]
[XmlInclude(typeof(DMD.RgbColorModelPercentage))]
[XmlInclude(typeof(DMD.PresetColor))]
[XmlInclude(typeof(DMD.SystemColor))]
[XmlInclude(typeof(DMD.HslColor))]
[XmlRoot("AbstractColor", Namespace = "DocumentModel")]
public abstract class AbstractColor<T> : ModelElement<T> where T : DX.OpenXmlElement
{
}