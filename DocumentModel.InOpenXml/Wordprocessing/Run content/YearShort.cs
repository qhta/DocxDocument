namespace DocumentModel.Wordprocessing;
/// <summary>
///   Represents a two-digit year field (yy) in a WordprocessingML run, used for date fields that display the year in short format.
/// </summary>
[OpenXmlType(typeof(DXW.YearShort))]
[DataContract]
[XmlRoot("YearShort", Namespace = "DocumentModel.Wordprocessing")]
public class YearShort : RunDate<DXW.YearShort>
{
}