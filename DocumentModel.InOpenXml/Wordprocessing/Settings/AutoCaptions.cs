namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a collection of automatic caption definitions for Wordprocessing documents.
/// </summary>
[XmlRoot("AutoCaptions")]
[OpenXmlType(typeof(AutoCaption))]
public class AutoCaptions : ModelElementCollection<AutoCaption, DXW.AutoCaptions, DXW.AutoCaption>
{
 /// <summary>
 /// Initializes a new instance of the <see cref = "AutoCaptions"/> class.
 /// </summary>
 public AutoCaptions()
 {
 }
 /// <summary>
 /// Initializes a new instance of the <see cref = "AutoCaptions"/> class with the specified captions.
 /// </summary>
 /// <param name = "captions">The collection of <see cref = "AutoCaption"/> items to include.</param>
 public AutoCaptions(IEnumerable<AutoCaption> captions) : base(captions)
 {
 }
}