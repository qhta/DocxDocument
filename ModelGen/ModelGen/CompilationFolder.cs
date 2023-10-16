using DocumentFormat.OpenXml.Drawing.Charts;

namespace ModelGen;

public record CompilationFolder: CompilationFile, ICollection<CompilationFile>
{
  public CompilationFolder(string name): base(name)
  { 
    Items = new CompilationFiles();
  }

  public CompilationFiles Items { get; set; }

  public void Add(CompilationFile item)
  {
    Items.Add(item.Filename, item);
  }

  public void Clear()
  {
    Items.Clear();
  }

  public bool Contains(CompilationFile item)
  {
    return Items.ContainsKey(item.Filename);
  }

  public void CopyTo(CompilationFile[] array, int arrayIndex)
  {
    Items.Values.ToArray().CopyTo(array, arrayIndex);
  }

  public bool Remove(CompilationFile item)
  {
    return Items.Remove(item.Filename);
  }

  public int Count => Items.Count;
  public bool IsReadOnly => false;

  public IEnumerator<CompilationFile> GetEnumerator()
  {
    return Items.Values.GetEnumerator();
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return Items.Values.GetEnumerator();
  }
}
