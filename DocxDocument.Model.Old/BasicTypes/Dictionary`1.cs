using System.Runtime.CompilerServices;

namespace DocxDocument.Model;

public class Dictionary<ItemType> : IEnumerable<KeyValuePair<string, ItemType>>, IDictionary<string, ItemType>
{
  private Dictionary<string, ItemType> Items;

  public Dictionary() : this(StringComparer.OrdinalIgnoreCase)
  {
  }

  public Dictionary(StringComparer comparer)
  {
    Items = new Dictionary<string, ItemType>(comparer);
  }

  IEnumerator<KeyValuePair<string, ItemType>> IEnumerable<KeyValuePair<string, ItemType>>.GetEnumerator()
  {
    return Items.GetEnumerator();
  }

  public IEnumerator<ItemType> GetEnumerator()
  {
    return Items.Values.GetEnumerator();
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return ((IEnumerable)Items.Values).GetEnumerator();
  }

  public void Add(string key, ItemType item)
  {
    Items.Add(key, item);
  }

  public void Add(KeyValuePair<string, ItemType> item)
  {
    Items.Add(item.Key, item.Value);
  }

  public void Clear()
  {
    Items.Clear();
  }

  public bool Contains(KeyValuePair<string, ItemType> item)
  {
    return Items.Contains(item);
  }

  public void CopyTo(KeyValuePair<string, ItemType>[] array, int arrayIndex)
  {
    throw new NotImplementedException($"{this.GetType().Name} does not implement CopyTo(array) method");
  }

  public bool Remove(KeyValuePair<string, ItemType> item)
  {
    return Items.Remove(item.Key);
  }

  public bool Contains(string key)
  {
    return Items.ContainsKey(key);
  }

  public void CopyTo(ItemType[] array, int arrayIndex)
  {
    Items.Values.CopyTo(array, arrayIndex);
  }

  public bool Remove(string key)
  {
    return Items.Remove(key);
  }

  [XmlIgnore] public int Count => Items.Count;

  [XmlIgnore] public bool IsReadOnly => false;

  public bool ContainsKey(string key)
  {
    return Items.ContainsKey(key);
  }

  public bool TryGetValue(string key, out ItemType value)
  {
    return Items.TryGetValue(key, out value);
  }

  public ItemType this[string key]
  {
    get => Items[key];
    set => Items[key] = value;
  }

  public ICollection<string> Keys => Items.Keys;

  public ICollection<ItemType> Values => Items.Values;


  public void _Set(ItemType? value, [CallerMemberName] string name = null!)
  {
    Set(name, value);
  }

  public ItemType? _Get([CallerMemberName] string name = null!)
  {
    return Get(name);
  }

  public void Set(string name, ItemType? value)
  {
    if (this.ContainsKey(name))
    {
      if (value == null)
      {
        this.Remove(name);
      }
      else
      {
        this[name] = value;
      }
    }
    if (value != null)
      this.Add(name, value);
  }

  public ItemType? Get(string name)
  {
    if (!this.ContainsKey(name))
      return default;
    return this[name];
  }
}
