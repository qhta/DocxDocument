using System.Runtime.Serialization;

namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Represents a color model element with a generic underlying Open XML element type.
/// </summary>
/// <typeparam name = "T">The type of the underlying Open XML element represented by this color model element. Must derive from
/// DX.OpenXmlElement.</typeparam>
[XmlInclude(typeof(DMWD.RgbColorModelHex))]
[XmlInclude(typeof(DMWD.SchemeColor))]
[JsonPolymorphic(TypeDiscriminatorPropertyName = "$type")]
[JsonDerivedType(typeof(DMWD.RgbColorModelHex), "DocumentModel.Wordprocessing.Drawings.RgbColorModelHex")]
[JsonDerivedType(typeof(DMWD.SchemeColor), "DocumentModel.Wordprocessing.Drawings.SchemeColor")]
[XmlRoot("WordAbstractColor", Namespace = "DocumentModel.Wordprocessing.Drawings")]
public abstract class WordAbstractColor<T> : ModelElement<T> where T : DX.OpenXmlElement
{
}