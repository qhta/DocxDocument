namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the previous version of paragraph mark run properties, used in <see cref = "ParagraphMarkRunPropertiesChange"/>.
/// This class extends <see cref = "BaseParagraphMarkRunProperties"/> and is used to store the state of paragraph mark formatting before a tracked change, enabling comparison and revision management in WordprocessingML documents.
/// </summary>
[OpenXmlType(typeof(DXW.PreviousParagraphMarkRunProperties))]
[DataContract]
[XmlRoot("PreviousParagraphMarkRunProperties", Namespace = "DocumentModel.Wordprocessing")]
public class PreviousParagraphMarkRunProperties : BaseParagraphMarkRunProperties<DXW.PreviousParagraphMarkRunProperties>
{
}