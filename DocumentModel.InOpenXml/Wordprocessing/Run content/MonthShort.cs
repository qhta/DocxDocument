namespace DocumentModel.Wordprocessing;
/// <summary>
///   Represents a numeric or abbreviated month field (MM or MMM) in a WordprocessingML run, used for date fields that display the month in short format (e.g., "01" or "Jan").
/// </summary>
[OpenXmlType(typeof(DXW.MonthShort))]
[DataContract]
[XmlRoot("MonthShort", Namespace = "DocumentModel.Wordprocessing")]
public class MonthShort : RunDate<DXW.MonthShort>
{
}