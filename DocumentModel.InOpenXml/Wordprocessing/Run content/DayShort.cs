namespace DocumentModel.Wordprocessing;
/// <summary>
///   Represents a two-digit day field (dd) in a WordprocessingML run, used for date fields that display the day in short format.
/// </summary>
[OpenXmlType(typeof(DXW.DayShort))]
[XmlRoot("DayShort", Namespace = "DocumentModel.Wordprocessing")]
public class DayShort : RunDate<DXW.DayShort>
{
}