using System.Reflection.Metadata.Ecma335;

namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Font Table Root Element.
/// </summary>
public class Fonts : ElementCollection<Font>
{
  //public new Collection<Font>? Items
  //{
  //  get => this;
  //  set
  //  {
  //    if (value!=null)
  //    {
  //      Clear();
  //      foreach (var item in value)
  //        Add(item);
  //    }
  //  }
  //}
}