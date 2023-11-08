namespace ModelGen;

public record FolderModel: FileModel, ICollection<FileModel>
{
  public FolderModel(string name): base(name)
  { 
    Items = new FilesList();
  }

  public FilesList Items { [DebuggerStepThrough] get; set; }

  public int TotalCount => Items.TotalCount+1;

  public void Add(FileModel item)
  {
    Items.Add(item.Filename, item);
  }

  public void Clear()
  {
    Items.Clear();
  }

  public bool Contains(FileModel item)
  {
    return Items.ContainsKey(item.Filename);
  }

  public void CopyTo(FileModel[] array, int arrayIndex)
  {
    Items.Values.ToArray().CopyTo(array, arrayIndex);
  }

  public bool Remove(FileModel item)
  {
    return Items.Remove(item.Filename);
  }

  public int Count => Items.Count;
  public bool IsReadOnly => false;

  public IEnumerator<FileModel> GetEnumerator()
  {
    return Items.Values.GetEnumerator();
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return Items.Values.GetEnumerator();
  }
}
