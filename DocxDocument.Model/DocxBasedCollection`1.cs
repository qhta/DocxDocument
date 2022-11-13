
namespace DocxDocument.Model;

public class DocxBasedCollection<DmItemType, IDmItemType, DocxElementType, DocxItemType> : IDocxBasedElement, ICollection<IDmItemType>
  where DmItemType : IDocxBasedElement, IDmItemType, new()
  where DocxElementType : OO.OpenXmlCompositeElement 
  where DocxItemType : OO.OpenXmlElement
{
  public DocxBasedCollection(OO.OpenXmlCompositeElement element)
  {
    DocxElement = element;
  }

  [XmlIgnore]
  public OO.OpenXmlElement OpenXmlElement
  {
    get => DocxElement;
    set => DocxElement = (OO.OpenXmlCompositeElement)value;
  }

  [XmlIgnore]
  public OO.OpenXmlCompositeElement DocxElement { get; set; }

  public IEnumerator<IDmItemType> GetEnumerator()
  {
    foreach (var docxItem in DocxElement.Elements<DocxItemType>())
      yield return new DmItemType { OpenXmlElement = docxItem };
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return GetEnumerator();
  }

  public void Add(IDmItemType item)
  {
    if (item is DmItemType dmItemType) 
      DocxElement.AddChild(dmItemType.OpenXmlElement);
  }

  public void Clear()
  {
    DocxElement.RemoveAllChildren();
  }

  public bool Contains(IDmItemType item)
  {
    if (item is DmItemType dmItemType)
      return DocxElement.Contains(dmItemType.OpenXmlElement);
    return false;
  }

  public void CopyTo(IDmItemType[] array, int arrayIndex)
  {
    foreach (var docxItem in DocxElement.Elements<DocxItemType>())
      array[arrayIndex++] = new DmItemType { OpenXmlElement = docxItem };
  }

  public bool Remove(IDmItemType item)
  {
    if (item is DmItemType dmItemType)
    {
      dmItemType.OpenXmlElement.Remove();
      return true;
    }
    return false;
  }

  [XmlIgnore] public int Count => DocxElement.Elements<DocxItemType>().Count();

  [XmlIgnore]
  public bool IsReadOnly { get; }
}