namespace DocumentModel;

public partial class BuiltInProperties : IDocumentProperties, IModelCollection<DocumentProperty>
{
  public bool TryAdd(DocumentProperty item)
  {
    throw new NotImplementedException();
  }
  IEnumerator<DocumentProperty> IEnumerable<DocumentProperty>.GetEnumerator() => this.GetEnumerator();


  DocumentProperty IModelCollection<DocumentProperty>.this[object index]
  {
    get
    {
      if (index is string propertyName)
        if (propertyNameMapping.TryGetValue1(propertyName, out var mappedName))
          index = mappedName;
      return this[(string)index];
    }

    set
    {
      if (index is string propertyName)
        if (propertyNameMapping.TryGetValue1(propertyName, out var mappedName))
          index = mappedName;
      this[(string)index] = (BuiltInProperty)value;
    }
  }
  private static readonly BiDiDictionary<string, string> propertyNameMapping = new()
  {
    {
      "Title",
      "Title"
    },
    {
      "Subject",
      "Subject"
    },
    {
      "Creator",
      "Author"
    },
    {
      "Keywords",
      "Keywords"
    },
    {
      "Description",
      "Comments"
    },
    {
      "LastModifiedBy",
      "LastAuthor"
    },
    {
      "Revision",
      "RevisionNumber"
    },
    {
      "Created",
      "CreationDate"
    },
    {
      "Modified",
      "ModificationDate"
    },
  };

  public void Add(DocumentProperty item)
  {
    throw new NotImplementedException();
  }
  public bool Contains(DocumentProperty item)
  {
    throw new NotImplementedException();
  }
  public void CopyTo(DocumentProperty[] array, int arrayIndex)
  {
    throw new NotImplementedException();
  }
  public bool Remove(DocumentProperty item)
  {
    throw new NotImplementedException();
  }
}
