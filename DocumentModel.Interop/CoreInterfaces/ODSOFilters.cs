
namespace DocumentModel.Interop.Core;

public interface ODSOFilters: InteropObject
{
  int Count { get; }
  object Item(int Index);

  void Add
  (string Column, MsoFilterComparison Comparison, MsoFilterConjunction Conjunction, string bstrCompareTo,
    bool DeferUpdate);

  void Delete(int Index, bool DeferUpdate);
}