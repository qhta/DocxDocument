namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a listing of all revision save ID values in a WordprocessingML document.
/// </summary>
[DataContract]
[XmlRoot("Rsids")]
[OpenXmlType(typeof(HexInt))]
public sealed partial class Rsids : ValueCollection<HexInt, DXW.Rsids, DXW.Rsid>
{
  /// <summary>
  /// Default constructor.
  /// </summary>
  public Rsids()
  {
  }
  /// <summary>
  /// Initializing constructor.
  /// </summary>
  /// <param name = "document">Wordprocessing document model</param>
  public Rsids(Document document): base(document, document.WordprocessingDocument?.GetRsids())
  {
  }

  /// <summary>
  /// Populates the data collection with the root revision save ID from the specified Rsids object, if it is not already
  /// present.
  /// </summary>
  /// <remarks>If the collection is empty or the first element does not match the root revision save ID from the
  /// provided Rsids object, the method inserts the root revision save ID at the beginning of the collection.</remarks>
  /// <param name="rsids">The Rsids object containing the root revision save ID to be loaded into the collection.</param>
  protected override void LoadDataCollection(DXW.Rsids rsids)
  {
    if (rsids.RsidRoot != null)
    {
      this.Clear();
      // ReSharper disable once SpecifyACultureInStringConversionExplicitly
      if (this.Count == 0 || this[0].ToString() != rsids.RsidRoot.Val?.Value)
      {
        this.Insert(0, new HexInt(rsids.RsidRoot.Val?.Value!));
      }
      foreach (var rsid in rsids.Elements<DXW.Rsid>())
      {
        // ReSharper disable once SpecifyACultureInStringConversionExplicitly
        var hexInt = new HexInt(rsid.Val?.Value!);
        this.Add(hexInt);
      }
    }
  }

  /// <summary>
  /// Store data from this instance to the specified wordprocessingDocument. Data is stored to the wordprocessingDocument's DocumentSettings.
  /// </summary>
  /// <param name="rsids"></param>
  protected override void UpdateDataCollection(DXW.Rsids rsids)
  {
    if (this.Count > 0)
    {
      // ReSharper disable once SpecifyACultureInStringConversionExplicitly
      rsids.RsidRoot = new DXW.RsidRoot
      {
        Val = new DX.HexBinaryValue(this[0].ToString())
      };
      if (rsids.Elements<DXW.Rsid>().Any())
      {
        var rsid = rsids.Elements<DXW.Rsid>().First();
        if (rsid.Val == rsids.RsidRoot.Val)
          rsid.Remove();
      }
      rsids.RemoveAllChildren<DXW.Rsid>();
      for (var i = 1; i < this.Count; i++)
      {
        var rsid = new DXW.Rsid
        {
          Val = new DX.HexBinaryValue(this[i].ToString())
        };
        rsids.Append(rsid);
      }
    }
    else
    {
      rsids.RsidRoot = null;
      rsids.RemoveAllChildren<DXW.Rsid>();
    }
  }
}