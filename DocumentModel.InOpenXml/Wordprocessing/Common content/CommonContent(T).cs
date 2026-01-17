namespace DocumentModel.Wordprocessing;

public class CommonContent<T>: CollectionItem where T : ICollectionItem
{
  protected override object? GetUpdatableOpenXmlElement()
  {
    throw new NotImplementedException();
  }
}