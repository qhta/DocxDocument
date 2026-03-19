using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface IFind
{
  string SearchPath { get; set; }
  string Name { get; set; }
  bool SubDir { get; set; }
  string Title { get; set; }
  string Author { get; set; }
  string Keywords { get; set; }
  string Subject { get; set; }
  MsoFileFindOptions Options { get; set; }
  bool MatchCase { get; set; }
  string Text { get; set; }
  bool PatternMatch { get; set; }
  object DateSavedFrom { get; set; }
  object DateSavedTo { get; set; }
  string SavedBy { get; set; }
  object DateCreatedFrom { get; set; }
  object DateCreatedTo { get; set; }
  MsoFileFindView View { get; set; }
  MsoFileFindSortBy SortBy { get; set; }
  MsoFileFindListBy ListBy { get; set; }
  int SelectedFile { get; set; }
  IFoundFiles Results { get; }
  int Show();
  void Execute();
  void Load(string bstrQueryName);
  void Save(string bstrQueryName);
  void Delete(string bstrQueryName);
  int FileType { get; set; }
}