using DocumentModel.CustomXml;
namespace DocumentModel.Wordprocessing;
/// <summary>
///   Additional schemas attached to document.
/// </summary>
public interface IAttachedSchemas: IElementCollection<ISchema>
{
}