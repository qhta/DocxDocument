namespace DocumentModel;
/// <summary>
/// Collection of document properties
/// </summary>
public interface IDocumentProperties<ItemType>: IElementCollection<ItemType>
  where ItemType : DocumentProperty
{
}