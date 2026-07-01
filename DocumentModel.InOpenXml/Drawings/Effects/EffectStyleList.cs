namespace DocumentModel.Drawings;
/// <summary>
/// Represents a collection of effect styles, each defining a set of effects and 3D properties for drawing elements.
/// </summary>
[OpenXmlType(typeof(EffectStyle))]
[DataContract]
[XmlRoot("EffectStyleList", Namespace = "DocumentModel.Drawings")]
public class EffectStyleList : ModelElementCollection<EffectStyle, DXD.EffectStyleList, DXD.EffectStyle>
{
}