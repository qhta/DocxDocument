namespace DocxDocument.Model;

public class Collection<KeyType, ItemType> : ICollection<ItemType>, IDictionary<KeyType, ItemType> where KeyType: IComparable<KeyType>
{

  private Dictionary<KeyType, ItemType> Items { get; set;}

  private PropertyInfo KeyProperty { get; set; }

  public Collection(): this(null)
  {

  }

  public Collection(IEqualityComparer<KeyType>? comparer)
  {
    Items = new Dictionary<KeyType, ItemType>(comparer);
    var keyProperty = typeof(ItemType).GetProperties().FirstOrDefault(item => item.GetCustomAttribute<KeyAttribute>() != null);
    if (keyProperty == null)
      throw new InvalidOperationException($"Type {typeof(ItemType).Name} does not have a key property");
    if (keyProperty.PropertyType != typeof(KeyType))
      throw new InvalidOperationException($"Type {typeof(ItemType).Name} has a key property of type {keyProperty.PropertyType} instead of type {typeof(KeyType).Name}");
    KeyProperty = keyProperty;
  }

  IEnumerator<KeyValuePair<KeyType, ItemType>> IEnumerable<KeyValuePair<KeyType, ItemType>>.GetEnumerator()
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

  public void Add(ItemType item)
  {
    var key = KeyProperty.GetValue(item);
    if (key is KeyType aKey)
      Items.Add(aKey,item);
  }

  public void Add(KeyValuePair<KeyType, ItemType> item)
  {
    Items.Add(item.Key, item.Value);
  }

  public void Clear()
  {
    Items.Clear();
  }

  public bool Contains(KeyValuePair<KeyType, ItemType> item)
  {
    return Items.Contains(item);
  }

  public void CopyTo(KeyValuePair<KeyType, ItemType>[] array, int arrayIndex)
  {
    throw new NotImplementedException($"{this.GetType().Name} does not implement CopyTo(array) method");
  }

  public bool Remove(KeyValuePair<KeyType, ItemType> item)
  {
    return Items.Remove(item.Key);
  }

  public bool Contains(ItemType item)
  {
    var key = KeyProperty.GetValue(item);
    if (key is KeyType aKey)
      return Items.ContainsKey(aKey);
    return false;
  }

  public void CopyTo(ItemType[] array, int arrayIndex)
  {
    Items.Values.CopyTo(array, arrayIndex);
  }

  public bool Remove(ItemType item)
  {
    var key = KeyProperty.GetValue(item);
    if (key is KeyType aKey)
      return Items.Remove(aKey);
    return false;
  }

  [XmlIgnore]
  public int Count => Items.Values.Count;

  [XmlIgnore]
  public bool IsReadOnly => false;

  public void Add(KeyType key, ItemType value)
  {
    Items.Add(key, value);
  }

  public bool ContainsKey(KeyType key)
  {
    return Items.ContainsKey(key);
  }

  public bool Remove(KeyType key)
  {
    return Items.Remove(key);
  }

  public bool TryGetValue(KeyType key, out ItemType value)
  {
    return Items.TryGetValue(key, out value);
  }

  public ItemType this[KeyType key]
  {
    get => Items[key];
    set => Items[key] = value;
  }

  public ICollection<KeyType> Keys => Items.Keys;

  public ICollection<ItemType> Values => Items.Values;
}