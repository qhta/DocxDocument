namespace DocumentModel.Wordprocessing;

public class Document : ModelElement, IDisposable
{
  internal DXPP.WordprocessingDocument? WordprocessingDocument { get; private set; }

  public Document()
  {

  }

  public static Document CreateDocument(string filePath)
  {
    var newDocument = new Document();
    newDocument.WordprocessingDocument = WordprocessingHelper.CreateWordDocument(filePath);
    return newDocument;
  }

  public void Dispose()
  {
    WordprocessingDocument?.Dispose();
    WordprocessingDocument = null;
    NotifyPropertyChanged(nameof(WordprocessingDocument));
  }
}