using DocumentModel.Properties;

namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document.
/// </summary>
public partial class Document
{
  public DocumentProperties? Properties { get; set; }
}
