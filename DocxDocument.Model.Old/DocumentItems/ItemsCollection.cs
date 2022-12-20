namespace DocxDocument.Model;

public class ItemsCollection<ItemType>: ICollection<ItemType> where ItemType: DocumentItem
{
  private IDictionary<int, ItemType> Items { get; } = new Dictionary<int, ItemType>();

  [XmlIgnore]
  [JsonIgnore]
  public Document? Document
  {
    get => _Document;
    set
    {
      if (_Document != value)
      {
        _Document = value;
        foreach (var item in Items)
          item.Value.Document = value;
      }
    }
  }
  private Document? _Document;

  public IEnumerator<ItemType> GetEnumerator()
  {
    return Items.Values.GetEnumerator();
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return this.GetEnumerator();
  }

  public void Add(ItemType item)
  {
    item.Document = Document;
    Items.Add(item.ID, item);
  }

  public bool Contains(ItemType item)
  {
    var ID = item.ID;
    return Items.ContainsKey(ID);
  }

  public void CopyTo(ItemType[] array, int arrayIndex)
  {
    Items.Values.CopyTo(array, arrayIndex);
  }

  public bool Remove(ItemType item)
  {
    var ID = item.ID;
    return Items.Remove(ID);
  }

  public void Clear()
  {
    Items.Clear();
  }

  public int Count => Items.Count;

  public bool IsReadOnly => false;

  public bool TryGetValue (int id, out ItemType item)
  {
    return Items.TryGetValue(id, out item);
  }

  public ItemType this[int id] => Items[id];

  public bool IsEmpty() => Count == 0;
}