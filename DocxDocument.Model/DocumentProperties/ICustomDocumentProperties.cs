namespace DocxDocument.Model;

public interface ICustomProperties: IEnumerable<ICustomDocumentProperty>
{
  int Count {get;}
  void Add(ICustomDocumentProperty property);
  bool Remove(ICustomDocumentProperty property);
}