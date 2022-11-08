
using DocumentFormat.OpenXml.Packaging;

using DM = DocxDocument.Model;


namespace DocxDocument.Reader;

public partial class DocxWriter
{
  public WordprocessingDocument WordprocessingDocument { get; private set; }

  public DocxWriter(WordprocessingDocument wordprocessingDocument)
  {
    WordprocessingDocument = wordprocessingDocument;
  }


  public void WriteDocument(DM.Document document)
  {
    WriteDocumentProperties(document.Properties);
  }


    
}