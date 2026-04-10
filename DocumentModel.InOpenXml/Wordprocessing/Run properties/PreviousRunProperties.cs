namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the previous version of run properties, used in <see cref = "RunPropertiesChange"/>.
/// This class extends <see cref = "ExtBaseRunProperties"/> and is used to store the state of run formatting before a tracked change, enabling comparison and revision management in WordprocessingML documents.
/// </summary>
[OpenXmlType(typeof(DXW.PreviousRunProperties))]
[XmlRoot("PreviousRunProperties", Namespace = "DocumentModel.Wordprocessing")]
public class PreviousRunProperties : ExtBaseRunProperties<DXW.PreviousRunProperties>
{
}