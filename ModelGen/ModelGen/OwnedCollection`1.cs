using System.Collections;

namespace ModelGen;

public class OwnedCollection<T> : ICollection, ICollection<T> where T : class, IOwnedElement
{
  private List<T> Items = new List<T>();

  private object Owner { get; }

  public OwnedCollection(object owner)
  { this.Owner = owner; }

  public IEnumerator<T> GetEnumerator()
  {
    return Items.GetEnumerator();
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return ((IEnumerable)Items).GetEnumerator();
  }

  public void Add(T item)
  {
    Items.Add(item);
    item.Owner = Owner;
  }

  public void Clear()
  {
    Items.Clear();
  }

  public bool Contains(T item)
  {
    return Items.Contains(item);
  }

  public void CopyTo(T[] array, int arrayIndex)
  {
    Items.CopyTo(array, arrayIndex);
  }

  public bool Remove(T item)
  {
    return Items.Remove(item);
  }

  public int Count => Items.Count;

  public bool IsReadOnly => false;

  public void CopyTo(Array array, int index)
  {
    ((ICollection)Items).CopyTo(array, index);
  }

  public bool IsSynchronized => ((ICollection)Items).IsSynchronized;

  public object SyncRoot => ((ICollection)Items).SyncRoot;
}
