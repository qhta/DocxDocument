
namespace DocumentModel.Interop.Core;

public interface ODSOFilters: InteropObject
{
  public int Count { get; }
  public object Item(int Index);

  public void Add
  (string Column, MsoFilterComparison Comparison, MsoFilterConjunction Conjunction, string bstrCompareTo,
    bool DeferUpdate);

  public void Delete(int Index, bool DeferUpdate);
}
