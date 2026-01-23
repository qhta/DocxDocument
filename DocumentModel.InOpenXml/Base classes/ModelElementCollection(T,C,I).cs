namespace DocumentModel;

public abstract class ModelElementCollection<ItemType, OpenXmlCollectionType, OpenXmlItemType>: 
  ModelElementCollection<ItemType, OpenXmlCollectionType>
  where ItemType : ModelElement
  where OpenXmlCollectionType: DX.OpenXmlCompositeElement
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
    foreach (var openXmlElement in openXmlModeledCollection!.ChildElements.Cast<OpenXmlItemType>())
    {
      var constructor = typeof(ItemType).GetConstructor([typeof(ModelElement<OpenXmlItemType>), typeof(OpenXmlItemType)]);
      ItemType modelObject;
      if (constructor != null)
      {
        modelObject = (ItemType)constructor.Invoke([this, openXmlElement]);
      }
      else
      {
        modelObject = Activator.CreateInstance<ItemType>();
        modelObject.LoadData(openXmlElement);
      }
      this.Add(modelObject);
    }
  }

  protected override void UpdateDataCollection(OpenXmlCollectionType openXmlModeledCollection)
  {
    var children = openXmlModeledCollection.Elements().Where(item => item is OpenXmlItemType).ToArray();
    foreach (var child in children)
    {
      child.Remove();
    }
    foreach (var item in this)
    {
      OpenXmlItemType openXmlElement = Activator.CreateInstance<OpenXmlItemType>();
      item.UpdateData(openXmlElement);
      openXmlModeledCollection.AppendChild(openXmlElement);
    }
  }
}