namespace DocxDocument.Model;

public interface ICustomDocumentProperties: IEnumerable<ICustomDocumentProperty>
{
  int Count {get;}
  void Add(ICustomDocumentProperty property);
  bool Remove(ICustomDocumentProperty property);
}