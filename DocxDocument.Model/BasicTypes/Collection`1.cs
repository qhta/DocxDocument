namespace DocxDocument.Model;

public class Collection<ItemType>: IList<ItemType>
{

  private List<ItemType> Items { get; } = new();


  public IEnumerator<ItemType> GetEnumerator()
  {
    return Items.GetEnumerator();
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return ((IEnumerable)Items).GetEnumerator();
  }

  public void Add(ItemType item)
  {
    Items.Add(item);
  }

  public void Clear()
  {
    Items.Clear();
  }

  public bool Contains(ItemType item)
  {
    return Items.Contains(item);
  }

  public void CopyTo(ItemType[] array, int arrayIndex)
  {
    Items.CopyTo(array, arrayIndex);
  }

  public bool Remove(ItemType item)
  {
    return Items.Remove(item);
  }

  [XmlIgnore]
  public int Count => Items.Count;

  [XmlIgnore]
  public bool IsReadOnly => false;

  public int IndexOf(ItemType item)
  {
    return Items.IndexOf(item);
  }

  public void Insert(int index, ItemType item)
  {
    Items.Insert(index, item);
  }

  public void RemoveAt(int index)
  {
    Items.RemoveAt(index);
  }

  public ItemType this[int index]
  {
    get => Items[index];
    set => Items[index] = value;
  }
}