
namespace DocumentModel.Interop.Core;

public interface ODSOFilters: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  int Count { get; }
  object Parent { get; }
  object Item(int Index);

  void Add
  (string Column, MsoFilterComparison Comparison, MsoFilterConjunction Conjunction, string bstrCompareTo = "",
    bool DeferUpdate = false);

  void Delete(int Index, bool DeferUpdate = false);
}