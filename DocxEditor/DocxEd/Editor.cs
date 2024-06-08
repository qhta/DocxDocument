using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DocumentModel.Wordprocessing;

namespace DocxEd;
public class Editor
{
  public List<Document> Documents { get; init; } = new List<Document>();

  public Document OpenFile(string filename, bool readWrite = true)
  {
    var document = new Document();
    document.Open(filename, readWrite);
    Documents.Add(document);
    return document;
  }
}
