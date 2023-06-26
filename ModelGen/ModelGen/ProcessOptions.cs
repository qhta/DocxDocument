namespace ModelGen;
public record ProcessOptions
{
  public PPS StopAtPhase { get; set; } = PPS.ScanTypes;

  public string ScanTypeName { get; set; } = "DocumentFormat.OpenXml.Packaging.WordprocessingDocument";

  public MDS Display { get; set; }

  public DisplayOptions? DisplayOptions { get; set; }


}
