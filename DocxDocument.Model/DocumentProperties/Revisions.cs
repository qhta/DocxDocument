using System.Linq;

namespace DocxDocument.Model;

public class Revisions: DocxBasedElement<WD.Rsids>, IRsIds
{
  public Revisions() : base(new WD.Rsids())
  {
  }

  public Revisions(WD.Rsids element): base(element)
  {
  }

  [XmlAttribute]
  public HexInt? RsidRoot 
  { 
    get => DocxElement.ReadHexInt<WD.RsidRoot>();
    set => DocxElement.WriteHexInt<WD.RsidRoot>(value);
  }

  public IEnumerator<HexInt> GetEnumerator()
  {
    foreach (var item in DocxElement.Elements<WD.Rsid>())
      if (item.Val?.Value != null)
         yield return new HexInt(item.Val.Value);
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return GetEnumerator();
  }

  public void Add(HexInt item)
  {
    DocxElement.AddChild(new WD.Rsid { Val = item.ToString() });
  }

  public void Clear()
  {
    DocxElement.RemoveAllChildren();
  }

  public bool Contains(HexInt item)
  {
    return DocxElement.Elements<WD.Rsid>().Any(item => String.Equals(item.Val?.Value, item.ToString(), StringComparison.OrdinalIgnoreCase));
  }

  public void CopyTo(HexInt[] array, int arrayIndex)
  {
    foreach (var item in DocxElement.Elements<WD.Rsid>())
      if (item.Val?.Value != null)
        array[arrayIndex++] = new HexInt(item.Val.Value);
  }

  public bool Remove(HexInt item)
  {
    var element = DocxElement.Elements<WD.Rsid>().FirstOrDefault(item => String.Equals(item.Val?.Value, item.ToString(), StringComparison.OrdinalIgnoreCase));
    if (element != null)
    {
      element.Remove();
      return true;
    }
    return false;
  }

  public int Count => DocxElement.Elements<WD.Rsid>().Count();

  public bool IsReadOnly { get; }
}