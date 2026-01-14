using System.Diagnostics;

namespace DocumentModel;

partial class CoreProperties
{

  public IEnumerator<DocumentProperty> GetEnumerator()
  {
    foreach (var item in KnownProperties)
    {
      var propertyInfo = typeof(CoreProperties).GetProperty(item.Key);
      var value = propertyInfo?.GetValue(this);
      yield return new DocumentProperty {
        Category = "Core",
        Name = item.Key, 
        Type = propertyInfo?.PropertyType,
				Value = value
      };
    }
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return GetEnumerator();
  }

  public void Add(DocumentProperty item)
  {
		// ignore this, as core properties are fixed
	}

	public void Clear()
  {
    // ignore this, as core properties are fixed
  }

	public bool Contains(DocumentProperty item)
  {
    return KnownProperties.ContainsKey(item.Name!);
  }

  public void CopyTo(DocumentProperty[] array, int arrayIndex)
  {
    var thisArray = this.ToArray();
    Array.Copy(thisArray, 0, array, arrayIndex, thisArray.Length);
	}

  public bool Remove(DocumentProperty item)
  {
    // ignore this, as core properties are fixed
    return false;
	}

	public int Count => KnownProperties.Count;

  public bool IsReadOnly => true;

  public int IndexOf(DocumentProperty item)
  {
    var thisArray = this.ToArray();
    var index = 0;
    foreach (var prop in thisArray)
    {
      if (prop.Equals(item))
      {
        return index;
      }
      index++;
    }
    return -1;
  }

	public void Insert(int index, DocumentProperty item)
  {
    // ignore this, as core properties are fixed
  }

	public void RemoveAt(int index)
  {
    // ignore this, as core properties are fixed
  }

	public DocumentProperty this[int index]
  {
    get => this.ToArray()[index];
    set
    {
      var item = this.ToArray()[index];
      if (item.Name == value.Name)
      {
        var propertyInfo = typeof(CoreProperties).GetProperty(item.Name!);
        propertyInfo?.SetValue(this, value.Name);
      }
      else
      {
        throw new InvalidOperationException("Cannot set a different property");
      }
    }
	}

  public event NotifyCollectionChangedEventHandler? CollectionChanged;
}

