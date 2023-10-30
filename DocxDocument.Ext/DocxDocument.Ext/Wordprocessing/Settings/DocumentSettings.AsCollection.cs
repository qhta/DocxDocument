namespace DocumentModel.Wordprocessing;
public partial class DocumentSettings : ICollection<Setting>
{
  public void Add(Setting item)
  {
    if (item.Name == null)
      throw new InvalidOperationException($"Item.Name must not be null");
    var propInfo = typeof(DocumentSettings).GetProperties().FirstOrDefault(item => item.Name != "Count");
    if (propInfo == null)
      throw new InvalidOperationException($"Property {item.Name} not found");
    var setMethod = propInfo.GetSetMethod(false);
    if (setMethod == null)
      throw new InvalidOperationException($"Set method for property {item.Name} does not exits");
    try
    {
      setMethod.Invoke(this, new object?[] { item.Value });
    }
    catch (Exception ex)
    {
      TestUtilities.ThrowError(ex);
    }
  }

  public void Clear()
  {
    throw new NotImplementedException();
  }

  public bool Contains(Setting item)
  {
    throw new NotImplementedException();
  }

  public void CopyTo(Setting[] array, int arrayIndex)
  {
    throw new NotImplementedException();
  }

  public bool Remove(Setting item)
  {
    throw new NotImplementedException();
  }

  public int Count => _DocumentSettings?.Elements().Count() ?? 0;

  public bool IsReadOnly => false;

  public bool IgnoreUnknown { get; set; }

  public IEnumerator<Setting> GetEnumerator()
  {
    var propNames = _ExistingSettings.Elements().Select(item => item.GetType().Name).ToArray();
    foreach (var propName in propNames)
    {
      var propInfo = typeof(DocumentSettings).GetProperty(propName);
      if (propInfo != null)
      {
        var getMethod = propInfo.GetGetMethod(false);
        if (getMethod == null)
          throw new InvalidOperationException($"get method for property {propInfo.Name} does not exits");
        object? obj = null;
        try
        {
          obj = getMethod.Invoke(this, new object?[] { });
        }
        catch (Exception ex)
        {
          TestUtilities.ThrowError(ex);
        }
        yield return new Setting { Name = propInfo.Name, Value = obj };
      }
      else
      {
        if (!IgnoreUnknown)
          throw new InvalidDataException($"DocumentSettings property {propName} not found");
      }
    }
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return this.GetEnumerator();
  }
}
