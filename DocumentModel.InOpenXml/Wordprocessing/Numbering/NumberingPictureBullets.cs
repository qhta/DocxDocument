namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a collection of picture numbering bullet elements in a WordprocessingML document.
/// This class provides access to and management of <see cref = "NumberingPictureBullet"/> objects, enabling advanced customization and organization of image-based list bullets for numbered and bulleted lists.
/// </summary>
[OpenXmlType(typeof(NumberingPictureBullet))]
[XmlRoot("NumberingPictureBullets", Namespace = "DocumentModel.Wordprocessing")]
public class NumberingPictureBullets : ElementCollection<NumberingPictureBullet>
{
}