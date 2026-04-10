namespace DocumentModel.Drawings;
/// <summary>
/// Represents a collection of foreground marks, which indicate areas to retain during background removal processing.
/// </summary>
[OpenXmlType(typeof(ForegroundMark))]
[XmlRoot("ForegroundMarks", Namespace = "DocumentModel.Drawings")]
public class ForegroundMarks : ElementCollection<ForegroundMark>
{
}