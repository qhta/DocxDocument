namespace DocumentModel;
using DocumentModel.Wordprocessing;
/// <summary>
/// Collection of all document properties that is divided to several parts: core properties, 
/// content properties, statistics properties, and custom properties. 
/// Document settings and web settings are also contained in this collection.
/// </summary>
public partial class AllDocumentProperties : ModelElement, 
  IElementCollection<DocumentProperty>, IDocumentProperties
{
  /// <summary>
  /// Collection of core properties, which represents document properties defined in Dublin Core standard
  /// and Open Packaging Conventions. 
  /// </summary>
  [XmlIgnore]
  public CoreProperties? CoreProperties { get; set; }
  /// <summary>
  /// Collection of content properties, which represents document properties defined in Microsoft Office standard.
  /// </summary>
  [XmlIgnore]
  public ContentProperties? ContentProperties { get; set; }
  /// <summary>
  /// Collection of statistic properties, which represents document metrics like characters count.
  /// </summary>
  [XmlIgnore]
  public StatisticProperties? StatisticProperties { get; set; }
  /// <summary>
  /// Collection of custom-defined document properties.
  /// </summary>
  [XmlIgnore]
  public CustomProperties? CustomProperties { get; set; }

  // Explicit implementation for INotifyCollectionChanged (if needed)
  public event NotifyCollectionChangedEventHandler? CollectionChanged
  {
    add
    {
      if (CoreProperties is INotifyCollectionChanged core) core.CollectionChanged += value;
      if (ContentProperties is INotifyCollectionChanged content) content.CollectionChanged += value;
      if (StatisticProperties is INotifyCollectionChanged stat) stat.CollectionChanged += value;
      //if (DocumentSettings is INotifyCollectionChanged docset) docset.CollectionChanged += value;
      //if (WebSettings is INotifyCollectionChanged web) web.CollectionChanged += value;
      if (CustomProperties is INotifyCollectionChanged custom) custom.CollectionChanged += value;
    }
    remove
    {
      if (CoreProperties is INotifyCollectionChanged core) core.CollectionChanged -= value;
      if (ContentProperties is INotifyCollectionChanged content) content.CollectionChanged -= value;
      if (StatisticProperties is INotifyCollectionChanged stat) stat.CollectionChanged -= value;
      //if (DocumentSettings is INotifyCollectionChanged docset) docset.CollectionChanged -= value;
      //if (WebSettings is INotifyCollectionChanged web) web.CollectionChanged -= value;
      if (CustomProperties is INotifyCollectionChanged custom) custom.CollectionChanged -= value;
    }
  }

  public IEnumerator<DocumentProperty> GetEnumerator()
  {
    throw new NotImplementedException();
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return GetEnumerator();
  }

  public void Add(DocumentProperty item)
  {
    throw new NotImplementedException();
  }

  public void Clear()
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

  public int Count { get; }
  public bool IsReadOnly { get; }
  public int IndexOf(DocumentProperty item)
  {
    throw new NotImplementedException();
  }

  public void Insert(int index, DocumentProperty item)
  {
    throw new NotImplementedException();
  }

  public void RemoveAt(int index)
  {
    throw new NotImplementedException();
  }

  public DocumentProperty this[int index]
  {
    get => throw new NotImplementedException();
    set => throw new NotImplementedException();
  }

}