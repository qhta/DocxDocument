namespace ModelGen;
public record ProcessOptions
{
  public int StopAtPhase { get; set; } = 1;

  public string ScanTypeName { get; set; } = "DocumentFormat.OpenXml.Packaging.WordprocessingDocument";

  public MDS Display { get; set; }

  public DisplayOptions? DisplayOptions { get; set; }


}
