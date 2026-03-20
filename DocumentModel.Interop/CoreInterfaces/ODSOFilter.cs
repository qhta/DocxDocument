
namespace DocumentModel.Interop.Core;

public interface ODSOFilter: InteropObject
{
  int Index { get; }
  string Column { get; set; }
  MsoFilterComparison Comparison { get; set; }
  string CompareTo { get; set; }
  MsoFilterConjunction Conjunction { get; set; }
}