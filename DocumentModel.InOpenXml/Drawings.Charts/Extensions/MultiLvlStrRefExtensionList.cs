namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a collection of multi-level string reference extensions.
/// </summary>
[DataContract]
[XmlRoot("MultiLvlStrRefExtensionList", Namespace = "DocumentModel.Drawings.Charts")]
public class MultiLvlStrRefExtensionList : ModelElementCollection<MultiLevelStrRefExtension>
{
}