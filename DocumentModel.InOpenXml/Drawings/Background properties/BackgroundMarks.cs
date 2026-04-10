namespace DocumentModel.Drawings;
/// <summary>
/// Represents a collection of background marks, which indicate areas to remove during background removal processing.
/// </summary>
[OpenXmlType(typeof(BackgroundMark))]
[XmlRoot("BackgroundMarks", Namespace = "DocumentModel.Drawings")]
public class BackgroundMarks : ElementCollection<BackgroundMark>
{
}