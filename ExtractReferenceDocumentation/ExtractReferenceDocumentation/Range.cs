using System.Collections.Generic;

using Microsoft.Office.Interop.Word;

using Word = Microsoft.Office.Interop.Word;

namespace ExtractReferenceDocumentation;

public class Range
{
  public Range(int start, int end)
  {
    Start = start;
    End = end;
  }

  public int Start { get; private set; }
  public int End { get; private set; }
}
