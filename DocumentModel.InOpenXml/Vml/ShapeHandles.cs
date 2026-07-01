namespace DocumentModel.Vml;
/// <summary>
///   Defines the ShapeHandles Class.
/// </summary>
[OpenXmlType(typeof(ShapeHandle))]
[DataContract]
[XmlRoot("ShapeHandles", Namespace = "DocumentModel.Vml")]
public class ShapeHandles : ModelElementCollection<ShapeHandle, DXV.ShapeHandles, DXV.ShapeHandle>
{
}