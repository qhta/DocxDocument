namespace DocumentModel;

public abstract class ModelElementCollection<ItemType, OpenXmlCollectionType, OpenXmlItemType>: 
  ModelElementCollection<ItemType, OpenXmlCollectionType>
  where ItemType : ModelElement<OpenXmlItemType>
  where OpenXmlCollectionType: DX.OpenXmlElement
  where OpenXmlItemType: DX.OpenXmlElement
{
  protected ModelElementCollection()
  {
  }

  protected ModelElementCollection(OpenXmlCollectionType? openXmlCollection) : base()
  {
  }

  protected ModelElementCollection(IEnumerable<ItemType> itemTypeCollection) : base()
  {
    foreach (var item in itemTypeCollection)
    {
      this.Add(item);
    }
  }

  protected override void LoadDataCollection(OpenXmlCollectionType openXmlModeledCollection)
  {
    this.Clear();
    foreach (var openXmlCustomDocumentProperty in openXmlModeledCollection!.ChildElements.Cast<OpenXmlItemType>())
    {
      var constructor = typeof(ItemType).GetConstructor([typeof(ModelElement<OpenXmlItemType>), typeof(OpenXmlItemType)]);
      ItemType modelObject = (ItemType)constructor!.Invoke([this, openXmlCustomDocumentProperty]);
      this.Add(modelObject);
    }
  }

  protected override void UpdateDataCollection(OpenXmlCollectionType openXmlModeledCollection)
  {
    throw new NotImplementedException();
  }
}