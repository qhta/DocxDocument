namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Listing of All Revision Save ID Values.
/// </summary>
public class Rsids : ValueCollection<HexInt>
{
  /// <summary>
  ///   Original Document Revision Save ID.
  /// </summary>
  public HexInt? RsidRoot { get; set; }

  //public new Collection<HexInt>? Items
  //{
  //  get => this;
  //  set
  //  {
  //    if (value != null)
  //    {
  //      Clear();
  //      foreach (var item in value)
  //        Add(item);
  //    }
  //  }
  //}
}