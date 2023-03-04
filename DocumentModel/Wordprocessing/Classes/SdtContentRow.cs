namespace DocumentModel.Wordprocessing;

/// <summary>
///   Row-Level Structured Document Tag Content.
/// </summary>
public class SdtContentRow: TableRow
{
  public Collection<TableRow>? TableRows { get; set; }

  public CustomXmlRow? CustomXmlRow { get; set; }

  public SdtRow? SdtRow { get; set; }

}