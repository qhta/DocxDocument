using DocumentModel.Properties;

namespace DocumentModel.Wordprocessing;

public partial interface Document
{
  public DocumentProperties? Properties { get; set; }
  //public DocumentProperties? Settings { get; set; }
}