namespace DocumentModel.Wordprocessing;
/// <summary>
/// Abstract element of the Story.
/// </summary>
/// <typeparam name = "T"></typeparam>
[DataContract]
[XmlRoot("StoryElement", Namespace = "DocumentModel.Wordprocessing")]
public partial class StoryElement<T> : CommonContent<T> where T : IStoryContent
{
}