namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a collection of caption elements used to define subtitles or captions for media content.
/// </summary>
/// <remarks>Use this class to manage multiple caption definitions, such as adding, removing, or enumerating
/// captions associated with a media element. This collection provides methods for manipulating caption elements and is
/// typically used in scenarios where media requires support for multiple languages or accessibility features.</remarks>
[XmlRoot("CaptionDefinitions")]
[OpenXmlType(typeof(CaptionDefinition))]
public class CaptionDefinitions : ElementCollection<CaptionDefinition>
{
 /// <summary>
 /// Default constructor.
 /// </summary>
 public CaptionDefinitions()
 {
 }

 /// <summary>
 /// Initializing constructor.
 /// </summary>
 /// <param name = "captions"></param>
 public CaptionDefinitions(IEnumerable<CaptionDefinition> captions) : base(captions)
 {
 }

 protected override object? GetUpdatableOpenXmlElement()
 {
  throw new NotImplementedException();
 }
}