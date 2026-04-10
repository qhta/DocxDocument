namespace DocumentModel.Wordprocessing;
/// <summary>
///   Base Table Grid.
///   Contains GridColumns only.
/// </summary>
[XmlRoot("BaseTableGrid", Namespace = "DocumentModel.Wordprocessing")]
public class BaseTableGrid<T> : GridColumns<T> where T : DX.OpenXmlCompositeElement
{
}