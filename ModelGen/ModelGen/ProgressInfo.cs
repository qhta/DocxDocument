namespace ModelGen;
public class ProgressInfo
{
  public string? FormatStr { get; set; }
  public object[]? Args { get; set; } = new object[] { };
  public string? PostStr { get; set; }

  public int? CheckedTypes => (Args != null && Args.Length>0) ? Args[0] as int? : null;
  public int? TotalTypes => (Args != null && Args.Length>1) ? Args[1] as int? : null;
  public int? ProcessedTypes => (Args != null && Args.Length>2) ? Args[2] as int? : null;
}
