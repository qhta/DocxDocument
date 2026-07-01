namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a collection of extension elements for a single data label.
/// </summary>
[DataContract]
[XmlRoot("DLblExtensionList", Namespace = "DocumentModel.Drawings.Charts")]
public class DLblExtensionList : ModelElementCollection<DataLabelExtension>
{
}