namespace DocumentModel;

public interface IXmlDOMTextWriter // : System.Xml.IXmlWriter
{
  public System.Xml.WriteState? WriteState { get ; set; }
  
  public System.Xml.XmlWriterSettings? Settings { get ; set; }
  
  public System.String? XmlLang { get ; set; }
  
  public System.Xml.XmlSpace? XmlSpace { get ; set; }
  
}
