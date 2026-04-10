namespace DocumentModel.Drawings.Charts;
/// <summary>
/// Represents a collection of axis elements within a chart or coordinate system.
/// </summary>
/// <remarks>The AxisList class provides access to the set of axes defined for a chart or similar structure.
/// It enables enumeration and manipulation of individual axis elements, such as X, Y, or Z axes, depending on the
/// context. The specific behavior and supported operations may depend on the implementation of the ModelElementCollection
/// class.</remarks>
[XmlRoot("AxisList", Namespace = "DocumentModel.Drawings.Charts")]
public class AxisList : ElementCollection<AbstractAxis>
{
}