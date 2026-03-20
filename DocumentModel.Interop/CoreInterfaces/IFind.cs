using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface IFind
{
  public string SearchPath { get; set; }
  public string Name { get; set; }
  public bool SubDir { get; set; }
  public string Title { get; set; }
  public string Author { get; set; }
  public string Keywords { get; set; }
  public string Subject { get; set; }
  public MsoFileFindOptions Options { get; set; }
  public bool MatchCase { get; set; }
  public string Text { get; set; }
  public bool PatternMatch { get; set; }
  public object DateSavedFrom { get; set; }
  public object DateSavedTo { get; set; }
  public string SavedBy { get; set; }
  public object DateCreatedFrom { get; set; }
  public object DateCreatedTo { get; set; }
  public MsoFileFindView View { get; set; }
  public MsoFileFindSortBy SortBy { get; set; }
  public MsoFileFindListBy ListBy { get; set; }
  public int SelectedFile { get; set; }
  public IFoundFiles Results { get; }
  public int Show();
  public void Execute();
  public void Load(string bstrQueryName);
  public void Save(string bstrQueryName);
  public void Delete(string bstrQueryName);
  public int FileType { get; set; }
}
