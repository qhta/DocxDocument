namespace DocumentModel;

public interface IXmlDOMTextWriter // : System.Xml.IXmlWriter
{
  public WriteState? WriteState { get ; set; }
  
  public XmlWriterSettings? Settings { get ; set; }
  
  public String? XmlLang { get ; set; }
  
  public XmlSpace? XmlSpace { get ; set; }
  
}
