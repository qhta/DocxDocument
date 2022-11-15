namespace DocxDocument.Model;

public interface ICustomDocumentProperties: IEnumerable<ICustomDocumentProperty>
{
  [XmlIgnore]
  int Count {get;}

  void Add(ICustomDocumentProperty property);
  bool Remove(ICustomDocumentProperty property);
}