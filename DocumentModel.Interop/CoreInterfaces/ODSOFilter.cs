
namespace DocumentModel.Interop.Core;

public interface ODSOFilter: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  int Index { get; }
  object Parent { get; }
  string Column { get; set; }
  MsoFilterComparison Comparison { get; set; }
  string CompareTo { get; set; }
  MsoFilterConjunction Conjunction { get; set; }
}