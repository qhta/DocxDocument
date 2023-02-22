using System.Reflection.Metadata.Ecma335;

namespace DocumentModel.Wordprocessing;

/// <summary>
///   Font Table Root Element.
/// </summary>
public class Fonts : Collection<Font>
{
  public new Collection<Font>? Items
  {
    get => this;
    set
    {
      if (value!=null)
      {
        Clear();
        foreach (var item in value)
          Add(item);
      }
    }
  }
}