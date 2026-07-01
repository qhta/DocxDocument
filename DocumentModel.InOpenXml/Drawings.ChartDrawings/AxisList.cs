namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
/// Represents a collection of axis elements within a model.
/// </summary>
[DataContract]
[XmlRoot("AxisList", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public class AxisList : ModelElementCollection<Axis>
{
}