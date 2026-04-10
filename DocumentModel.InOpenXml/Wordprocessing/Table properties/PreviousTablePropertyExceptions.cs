namespace DocumentModel.Wordprocessing;
/// <summary>
/// Previous table property exceptions interface used in <see cref = "TablePropertyExceptionsChange"/>.
/// Represents the previous version of <see cref = "TablePropertyExceptions"/>, enabling tracking and management of historical table property exception settings.
/// </summary>
[OpenXmlType(typeof(DXW.PreviousTablePropertyExceptions))]
[XmlRoot("PreviousTablePropertyExceptions", Namespace = "DocumentModel.Wordprocessing")]
public class PreviousTablePropertyExceptions : CurrentTableProperties<DXW.PreviousTablePropertyExceptions>
{
}