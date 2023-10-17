namespace ModelGen;

public class FilesList : Dictionary<string, FileModel>
{
  public int TotalCount
  {
    get
    {
      var count = 0;
      foreach (var item in this)
        if (item.Value is FolderModel folder)
          count += folder.TotalCount;
        else
          count++;
      return count;
    }
  }
}
