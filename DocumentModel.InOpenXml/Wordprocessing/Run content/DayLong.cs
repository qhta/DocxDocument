namespace DocumentModel.Wordprocessing;
/// <summary>
///   Represents a full day name field (dddd) in a WordprocessingML run, used for date fields that display the day in long format (e.g., "Monday").
/// </summary>
[OpenXmlType(typeof(DXW.DayLong))]
[XmlRoot("DayLong", Namespace = "DocumentModel.Wordprocessing")]
public class DayLong : RunDate<DXW.DayLong>
{
}