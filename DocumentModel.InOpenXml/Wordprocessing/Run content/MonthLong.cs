namespace DocumentModel.Wordprocessing;
/// <summary>
///   Represents a full month name field (MMMM) in a WordprocessingML run, used for date fields that display the month in long format (e.g., "January").
/// </summary>
[OpenXmlType(typeof(DXW.MonthLong))]
[DataContract]
[XmlRoot("MonthLong", Namespace = "DocumentModel.Wordprocessing")]
public class MonthLong : RunDate<DXW.MonthLong>
{
}