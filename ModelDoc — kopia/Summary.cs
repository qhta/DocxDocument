using System.Collections.ObjectModel;

namespace ModelDoc;
public class Summary: ObservableCollection<string>
{
  public bool IsEmpty => Count == 0;
}
