namespace DocumentModel.Wordprocessing;

/// <summary>
///   Listing of All Revision Save ID Values.
/// </summary>
public class Rsids : Collection<HexInt>
{
  /// <summary>
  ///   Original Document Revision Save ID.
  /// </summary>
  public HexInt? RsidRoot { get; set; }

  public new Collection<HexInt>? Items
  {
    get => this;
    set
    {
      if (value != null)
      {
        Clear();
        foreach (var item in value)
          Add(item);
      }
    }
  }
}