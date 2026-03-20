
namespace DocumentModel.Interop.Core;

public partial interface ODSOFilters
{
  public object Item(int Index);
  public void Add
  (string Column, MsoFilterComparison Comparison, MsoFilterConjunction Conjunction, string bstrCompareTo,
    bool DeferUpdate);
  public void Delete(int Index, bool DeferUpdate);
}
