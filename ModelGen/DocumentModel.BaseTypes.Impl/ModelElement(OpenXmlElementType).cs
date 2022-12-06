namespace DocumentModel;

public class ModelElement<T>: DocumentModel.Impl.ModelElement
{
  public new T? OpenXmlElement { get => (T?)base.OpenXmlElement; set=>base.OpenXmlElement = value;}
}