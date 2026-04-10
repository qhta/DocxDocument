namespace DocumentModel.Wordprocessing;
/// <summary>
///   Represents a four-digit year field (yyyy) in a WordprocessingML run, used for date fields that display the year in long format.
/// </summary>
[OpenXmlType(typeof(DXW.YearLong))]
[XmlRoot("YearLong", Namespace = "DocumentModel.Wordprocessing")]
public class YearLong : RunDate<DXW.YearLong>
{
}