namespace ModelGen;
public static class UniqueSetUtils
{
  public static bool AddUnique<T>(this HashSet<T> list, T item)
  {
    if (!list.Contains(item))
    {
      list.Add(item);
      return true;
    }
    return false;
  }

  public static void AddRange<T>(this HashSet<T> list, IEnumerable<T> items)
  {
    foreach (var item in items)
    {
      if (!list.Contains(item))
      {
        list.Add(item);
      }
    }
  }
}
